using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    public partial class Form1 : Form
    {
        List<Expense> _expenses;
        string[] _categories = { "식비", "교통비", "주거비", "의류", "의료비", "취미/여가", "기타" };

        public Form1()
        {
            InitializeComponent();
            _expenses = new List<Expense>();

            InitDateInfo();

            cbxFilterCategory.Items.Add("전체");
            foreach (string category in _categories) {
                cbxCategory.Items.Add(category);
                cbxFilterCategory.Items.Add(category);
            }

            cbxFilterCategory.SelectedIndex = 0;

            #region 예제 자료
            _expenses.Add(
                new Expense() {
                    Description = "한라봉",
                    Amount = 12000,
                    Category = "식비",
                    Date = new DateTime(2025, 2, 20)
                });
            _expenses.Add(
                new Expense() {
                    Description = "전기료",
                    Amount = 35200,
                    Category = "주거비",
                    Date = new DateTime(2025, 2, 28)
                });
            _expenses.Add(
                new Expense() {
                    Description = "전기료",
                    Amount = 12000,
                    Category = "주거비",
                    Date = new DateTime(2025, 3, 30)
                });
            #endregion
        }

        private void InitDateInfo()
        {
            tbxExpenseDateYear.Text = DateTime.Now.Year.ToString();
            tbxExpenseDateMonth.Text = DateTime.Now.Month.ToString();
            tbxExpenseDateDay.Text = DateTime.Now.Day.ToString();

            tbxFilterExpenseDateYear.Text = DateTime.Now.Year.ToString();
            tbxFilterExpenseDateMonth.Text = DateTime.Now.Month.ToString();
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxDescription.Text.Trim())) {
                MessageBox.Show("설명을 입력하세요.");
                tbxDescription.Focus();
                return;
            }

            if (cbxCategory.SelectedIndex < 0) {
                MessageBox.Show("카테고리를 선택하세요.");
                cbxCategory.Focus();
                return;
            }

            if (!int.TryParse(txtAmount.Text, out int amount)) {
                MessageBox.Show("금액을 올바르게 입력하세요.");
                txtAmount.Focus();
                return;
            }

            if (amount <= 0) {
                MessageBox.Show("금액은 0보다 커야 합니다.");
                txtAmount.Focus();
                return;
            }

            Expense expense = new Expense {
                Description = tbxDescription.Text.Trim(),
                Category = cbxCategory.SelectedItem.ToString(),
                Amount = amount,
                Date = new DateTime(int.Parse(tbxExpenseDateYear.Text), int.Parse(tbxExpenseDateMonth.Text), int.Parse(tbxExpenseDateDay.Text))
            };

            _expenses.Add(expense);
            ClearInputs();
            MessageBox.Show("지출 항목이 추가되었습니다.");
        }

        private void ClearInputs()
        {
            InitDateInfo();

            tbxDescription.Text = string.Empty;
            txtAmount.Text = string.Empty;
            cbxCategory.SelectedIndex = -1;
            lblTotalPrice.Text = "";
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            lstExpenses.Items.Clear();

            string selectedCategory = cbxFilterCategory.SelectedIndex > 0 ?
                cbxFilterCategory.SelectedItem.ToString() : null;

            if (false == int.TryParse(tbxFilterExpenseDateYear.Text, out int year)) {
                return;
            }

            if (false == int.TryParse(tbxFilterExpenseDateMonth.Text, out int month)) {
                return;
            }


            int total = 0;
            foreach (Expense expense in _expenses) {
                if (selectedCategory == null || expense.Category == selectedCategory) {
                    if (expense.Date.Year == year && expense.Date.Month == month) {
                        lstExpenses.Items.Add(expense);
                        total += expense.Amount;
                    }
                }
            }

            if (lstExpenses.Items.Count == 0) {
                lblTotalPrice.Text = "";
                MessageBox.Show("조회 결과가 없습니다.");
            } else {
                lblTotalPrice.Text = total.ToString("N0") + "원";
            }
        }
    }
}