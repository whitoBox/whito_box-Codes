using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LabraryBook
{
    public partial class Form1 : Form
    {
        List<Book> _books;

        public Form1()
        {
            InitializeComponent();
            _books = new List<Book>();

            #region 예제
            _books.Add(new Book() {
                Title = "C#을 찾아서",
                Author = "김인하",
                ISBN = "123456",
                IsCheckedOut = false,
                RentDate = DateTime.Now
            });

            _books.Add(new Book() {
                Title = "자료구조란 무엇인가",
                Author = "김태간",
                ISBN = "123457",
                IsCheckedOut = true,
                RentDate = DateTime.Now.AddDays(-3),
            });

            _books.Add(new Book() {
                Title = "그래서 DB는?",
                Author = "이인하",
                ISBN = "123458",
                IsCheckedOut = true,
                RentDate = DateTime.Now.AddDays(-33),
            });
            #endregion
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxTitle.Text.Trim())) {
                tbxTitle.Focus();
                MessageBox.Show("제목을 입력하세요.");
                return;
            }

            if (string.IsNullOrEmpty(tbxAuthor.Text.Trim())) {
                tbxAuthor.Focus();
                MessageBox.Show("저자를 입력하세요.");
                return;
            }

            if (string.IsNullOrEmpty(tbxISBN.Text.Trim())) {
                tbxISBN.Focus();
                MessageBox.Show("ISBN을 입력하세요.");
                return;
            }

            Book book = new Book {
                Title = tbxTitle.Text.Trim(),
                Author = tbxAuthor.Text.Trim(),
                ISBN = tbxISBN.Text.Trim(),
                IsCheckedOut = false,
                RentDate = DateTime.Now
            };

            _books.Add(book);
            MessageBox.Show("도서가 추가되었습니다.");
            ClearAddBookInputs();
        }

        private void ClearAddBookInputs()
        {
            tbxTitle.Text = string.Empty;
            tbxAuthor.Text = string.Empty;
            tbxISBN.Text = string.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbxSearchResults.Items.Clear();
            string searchTerm = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm)) {
                MessageBox.Show("검색어를 입력하세요.");
                return;
            }

            foreach (Book book in _books) {
                if (book.Title.Contains(searchTerm) 
                    || book.Author.Contains(searchTerm) 
                    || book.ISBN.Contains(searchTerm)) {
                    lbxSearchResults.Items.Add(book);
                }
            }

            if (lbxSearchResults.Items.Count == 0) {
                MessageBox.Show("검색 결과가 없습니다.");
            }
        }

        private void lbxSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxSearchResults.SelectedIndex >= 0 
                && lbxSearchResults.SelectedItem is Book selectedBook) {
                lblBookTitle.Text = selectedBook.Title;
                lblBookAuthor.Text = selectedBook.Author;
                lblBookISBN.Text = selectedBook.ISBN;
                lblStatus.Text = selectedBook.IsCheckedOut ? "대출 중" : "대출 가능";

                if (selectedBook.IsCheckedOut) {
                    lblRentDate.Text = selectedBook.RentDate.ToString("yyyy-MM-dd");
                    lblDueDate.Text = selectedBook.DueDate().ToString("yyyy-MM-dd");
                    if (selectedBook.IsOverDue()) {
                        lblDueDate.Text += "(연체중)";
                    }
                    btnCheckout.Enabled = false;
                    btnReturn.Enabled = true;
                } else {
                    lblRentDate.Text
                        = lblDueDate.Text
                        = "-";
                    btnCheckout.Enabled = true;
                    btnReturn.Enabled = false;
                }
            } else {
                ClearBookDetails();
            }
        }

        private void ClearBookDetails()
        {
            lblBookTitle.Text = string.Empty;
            lblBookAuthor.Text = string.Empty;
            lblBookISBN.Text = string.Empty;
            lblStatus.Text = string.Empty;
            lblRentDate.Text = string.Empty;
            lblDueDate.Text = string.Empty;
            btnCheckout.Enabled = false;
            btnReturn.Enabled = false;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (lbxSearchResults.SelectedIndex >= 0 
                && lbxSearchResults.SelectedItem is Book selectedBook) {
                selectedBook.IsCheckedOut = true;
#if false
                selectedBook.RentDate = DateTime.Now.AddDays((new Random()).Next(7, 20));
#else
                selectedBook.RentDate = DateTime.Now;
#endif

                lbxSearchResults_SelectedIndexChanged(this, EventArgs.Empty);
                MessageBox.Show($"'{selectedBook.Title}' 대출되었습니다. 반납일: {selectedBook.RentDate.ToString("yyyy-MM-dd")}");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (lbxSearchResults.SelectedIndex >= 0 
                && lbxSearchResults.SelectedItem is Book selectedBook) {
                selectedBook.IsCheckedOut = false;

                lbxSearchResults_SelectedIndexChanged(this, EventArgs.Empty);
                MessageBox.Show($"'{selectedBook.Title}' 반납되었습니다.");
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearAddBookInputs();
            ClearBookDetails();
        }
    }
}