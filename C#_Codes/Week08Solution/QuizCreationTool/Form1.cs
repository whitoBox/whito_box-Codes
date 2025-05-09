using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuizCreationTool
{
    public partial class Form1 : Form
    {
        List<Question> _questions;
        int _currentIndex = -1;
        RadioButton[] _rbtOptions;
        TextBox[] _tbxOptions;

        public Form1()
        {
            InitializeComponent();
            _questions = new List<Question>();
            _rbtOptions = new RadioButton[]{
                rbtOption1,
                rbtOption2,
                rbtOption3,
                rbtOption4
            };

            _tbxOptions = new TextBox[] {
                tbxOption1,
                tbxOption2,
                tbxOption3,
                tbxOption4,
            };
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuestionText.Text.Trim())) {
                MessageBox.Show("문제를 입력하세요.");
                txtQuestionText.Focus();
                return;
            }

            for (int i = 0; i < 2; i++) {
                if (string.IsNullOrEmpty(_tbxOptions[i].Text.Trim())) {
                    MessageBox.Show("최소 2개의 옵션을 입력해야 합니다.");
                    _tbxOptions[i].Focus();
                    return;
                }
            }

            int correctAnswerIndex = -1;
            for (int i = 0; i < _rbtOptions.Length; i++) {
                if (_rbtOptions[i].Checked) {
                    if (false == string.IsNullOrEmpty(_tbxOptions[i].Text.Trim())) {
                        correctAnswerIndex = i;
                        break;
                    } else {
                        MessageBox.Show("정답으로 선택한 옵션에 텍스트를 입력해야 합니다.");
                        _tbxOptions[i].Focus();
                        return;
                    }
                }
            }

            if (correctAnswerIndex == -1) {
                MessageBox.Show("정답을 선택하세요.");
                return;
            }

            if (btnAddQuestion.Text == "문제 추가") {
                Question question = new Question {
                    QuestionText = txtQuestionText.Text.Trim(),
                    Options = new List<string>(),
                    CorrectAnswerIndex = correctAnswerIndex
                };

                for (int i = 0; i < _tbxOptions.Length; i++) {
                    var option = _tbxOptions[i].Text.Trim();
                    if (string.IsNullOrEmpty(option)) {
                        break;
                    }
                    question.Options.Add(option);
                }

                _questions.Add(question);
                MessageBox.Show("문제가 추가되었습니다.");
            } else {
                if (_currentIndex >= 0 && _currentIndex < _questions.Count) {
                    Question question = _questions[_currentIndex];
                    question.QuestionText = txtQuestionText.Text.Trim();
                    question.CorrectAnswerIndex = correctAnswerIndex;
                    question.Options.Clear();

                    for (int i = 0; i < _tbxOptions.Length; i++) {
                        var option = _tbxOptions[i].Text.Trim();
                        if (string.IsNullOrEmpty(option)) {
                            break;
                        }
                        question.Options.Add(option);
                    }

                    MessageBox.Show("문제가 수정되었습니다.");
                }
            }

            UpdateQuestionList();
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtQuestionText.Text = string.Empty;
            foreach (var tbx in _tbxOptions) {
                tbx.Text = string.Empty;
            }
            foreach (var rbt in _rbtOptions) {
                rbt.Checked = false;
            }

            btnAddQuestion.Text = "문제 추가";
            grpCreateQuestion.Text = "문제 생성";
            _currentIndex = -1;
        }

        private void UpdateQuestionList()
        {
            lbxQuestions.Items.Clear();
            for (int i = 0; i < _questions.Count; i++) {
                lbxQuestions.Items.Add($"[{i}] {_questions[i]}");
            }
        }

        private void lbxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxQuestions.SelectedIndex >= 0) {
                _currentIndex = lbxQuestions.SelectedIndex;
                DisplayQuestion(_currentIndex);
            }
        }

        private void DisplayQuestion(int index)
        {
            if (index >= 0 && index < _questions.Count) {
                Question question = _questions[index];

                txtQuestionText.Text = question.QuestionText;

                foreach (var tbx in _tbxOptions) {
                    tbx.Text = string.Empty;
                }
                foreach (var rbt in _rbtOptions) {
                    rbt.Checked = false;
                }

                // Display options
                for (int i = 0; i < question.Options.Count; i++) {
                    _tbxOptions[i].Text = question.Options[i];
                }

                if (-1 < question.CorrectAnswerIndex && question.CorrectAnswerIndex < _rbtOptions.Length) {
                    _rbtOptions[question.CorrectAnswerIndex].Checked = true;
                }

                // Change add button to update button when viewing a question
                btnAddQuestion.Text = "문제 수정";
            }
        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (lbxQuestions.SelectedIndex >= 0) {
                _questions.RemoveAt(lbxQuestions.SelectedIndex);
                UpdateQuestionList();
                ClearInputs();
                MessageBox.Show("문제가 삭제되었습니다.");
            } else {
                MessageBox.Show("삭제할 문제를 선택하세요.");
            }
        }
    }
}
