using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;    //파일 개체 활용

namespace mook_Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Boolean txtNoteChange; //내용 변경 체크
        private string fWord; //찾기 문자열
        private Form2 frm2; // 폼2 개체(frm2)생성

        private void 새로만들기NToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.txtNoteChange == true)
            {
                var msg = this.Text + " 파일의 내용이 변경되었습니다. \r\n 변경된 내용을 저장하시겠습니까?";
                var dlr = MessageBox.Show(msg, "메모장", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dlr == DialogResult.Yes)
                {
                    textSave();
                    this.txtNote.ResetText();
                    this.Text = "제목 없음";
                    this.txtNoteChange = false;
                }
                else if (dlr == DialogResult.No)
                {
                    this.txtNote.ResetText();
                    this.Text = "제목 없음";
                    this.txtNoteChange = false;
                }
                else if (dlr == DialogResult.Cancel)
                {
                    return;
                }
                else
                {
                    this.txtNote.ResetText();
                    this.Text = "제목 없음";
                    this.txtNoteChange = false;
                }
            }
            else
            {
                this.txtNote.ResetText();
                this.Text = "제목 없음";
                this.txtNoteChange = false;
            }
        }

        private void textSave()
        {
            if (this.Text == "제목 없음")
            {
                var dlr = this.sfdFile.ShowDialog();
                if (dlr != DialogResult.Cancel)
                {
                    var str = this.sfdFile.FileName;
                    var sw = new StreamWriter(str, false, System.Text.Encoding.Default);
                    sw.Write(this.txtNote.Text);
                    sw.Flush();
                    sw.Close();
                    this.Text = str;
                    this.txtNoteChange = false;
                }
            }
            else
            {
                var strt = this.Text;
                var sw = new StreamWriter(strt, false, System.Text.Encoding.Default);
                sw.Write(this.txtNote.Text);
                sw.Flush();
                sw.Close();
                this.Text = strt;
                this.txtNoteChange = false;
            }
        }

        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txtNoteChange == true) // [txtNote] 컨트롤의 입력 데이터가 수정 및 추가되었을 때
            {
                var msg = this.Text + " 파일의 내용이 변경되었습니다. \r\n 변경된 내용을 저장하시겠습니까?";
                var dlr = MessageBox.Show(msg, "메모장", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dlr == DialogResult.Yes)
                {
                    textSave(); // 데이터 저장 메서드 호출
                    textOpen(); // 파일 열기 메서드 호출
                }
                else if (dlr == DialogResult.No)
                {
                    textOpen(); //저장하지 않고 파일 열기 메서드 호출
                }
                else if (dlr == DialogResult.Cancel)
                {
                    return; //저장 및 열기 하지 않고 모든 작업을 취소한다.
                }
            }
            else
            {
                textOpen(); // [txtNote] 컨트롤의 입력 데이터가 수정 및 추가 되지 않았다.
            }
        }

        private void textOpen()
        {
            var dr = this.ofdFile.ShowDialog();
            if (dr != DialogResult.Cancel)
            {
                var str = this.ofdFile.FileName;
                var sr = new StreamReader(str, System.Text.Encoding.Default);
                this.txtNote.Text = sr.ReadToEnd();
                sr.Close();
                this.Text = str;
                this.txtNoteChange = false;
            }
        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            this.txtNoteChange = true; //데이터 추가
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (this.txtNoteChange == true)
            {
                var msg = this.Text + " 파일의 내용이 변경되었습니다. \r\n 변경된 내용을 저장하시겠습니까?";
                var dlr = MessageBox.Show(msg, "메모장", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dlr == DialogResult.Yes)
                {
                    if (this.Text == "제목 없음")
                    {
                        var dr = this.sfdFile.ShowDialog();
                        if (dr != DialogResult.Cancel)
                        {
                            var str = this.sfdFile.FileName;
                            var sw = new StreamWriter(str, false, System.Text.Encoding.Default);
                            sw.Write(this.txtNote.Text);
                            sw.Flush();
                            sw.Close();
                            this.txtNoteChange = false;
                        }
                    }
                    else
                    {
                        var str = this.Text;
                        var sw = new StreamWriter(str, false, System.Text.Encoding.Default);
                        sw.Write(this.txtNote.Text);
                        sw.Flush();
                        sw.Close();
                        this.txtNoteChange = false;
                    }
                    this.Dispose();
                }
                else if (dlr == DialogResult.No)
                {
                    this.Dispose();
                }
                else if (dlr == DialogResult.Cancel)
                {
                    return;
                }
            }
            else
            {
                this.Dispose();
            }
        }

        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textSave(); //저장 함수 호출
        }

        private void 다른이름으로저장AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlr = this.sfdFile.ShowDialog(); //[다른 이름으로 저장] 대화상자 호출
            if (dlr != DialogResult.Cancel)
            {
                var str = this.sfdFile.FileName; //파일 경로 
                var sw = new StreamWriter(str, false, System.Text.Encoding.Default); //StreamWriter 생성자를 이용하여 개체 생성
                sw.Write(this.txtNote.Text); // Write 메서드를 이용하여 지정된 경로에 txtNote 컨트롤의 입력 문자열 저장
                sw.Flush();
                sw.Close();
                this.Text = str;
                this.txtNoteChange = false; //입력 데이터 입력 및 수정 초기화
            }
        }

        private void 끝내기XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); //폼 종료
        }

        private void 실행취소UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtNote.Undo(); //텍스트 박스의 변경사항을 취소하고 이전 상태로 되돌려줌
        }

        private void 잘라내기TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtNote.Cut(); //선택된 텍스트를 잘라낸다.
        }

        private void 복사CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtNote.Copy(); //선택된 텍스트를 복사한다.
        }

        private void 붙여넣기PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtNote.Paste(); //텍스트 데이터 붙여넣기
        }

        private void 삭제LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtNote.SelectedText = ""; //선택된 텍스트 지우기
        }

        private void 찾기FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(frm2 == null || !frm2.Visible))
            {
                frm2.Focus();
                return;
            }
            frm2 = new Form2();

            if (this.txtNote.SelectionLength == 0)
            {
                frm2.txtWord.Text = this.fWord;
            }
            else
            {
                frm2.txtWord.Text = this.txtNote.SelectedText;
            }
            frm2.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            frm2.Show();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            var updown = -1;
            var str = this.txtNote.Text; //본문 저장
            var findWord = frm2.txtWord.Text; //찾을 문자열 저장

            if (!frm2.chOption.Checked)
            {
                str = str.ToUpper(); //저장된 본문을 대문자로 변환
                findWord = findWord.ToUpper();
            }

            if (frm2.rdb01.Checked)
            {
                if (this.txtNote.SelectionStart != 0)
                {
                    updown = str.LastIndexOf(findWord, this.txtNote.SelectionStart - 1);
                }
            }
            else
            {
                updown = str.IndexOf(findWord, this.txtNote.SelectionStart + this.txtNote.SelectionLength);
            }

            if (updown == -1)
            {
                MessageBox.Show("더 이상 찾는 문자열이 없습니다.", "메모장", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.txtNote.Select(updown, findWord.Length);
            fWord = frm2.txtWord.Text;
            this.txtNote.Focus();
            this.txtNote.ScrollToCaret();
        }

        private void 다음찾기NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(frm2 == null || !frm2.Visible))
            {
                frm2.txtWord.Text = this.fWord;
                this.btnOk_Click(this, null);
            }
        }

        private void 모두선택AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtNote.SelectAll(); //메모장의 텍스트 모두 선택
        }

        private void 시간날짜DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var time = DateTime.Now.ToShortTimeString(); //현재 시간 얻기
            var date = DateTime.Today.ToShortDateString(); //오늘 날짜 얻기
            this.txtNote.AppendText(time + "/" + date); //입력 데이터 맨뒤에 이어서 시간/날짜 정보 추가
        }

        private void 자동줄바꿈WToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtNote.WordWrap = !(this.txtNote.WordWrap);
            자동줄바꿈WToolStripMenuItem.Checked = !(자동줄바꿈WToolStripMenuItem.Checked);
        }

        private void 글꼴FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.fdText.ShowDialog() != DialogResult.Cancel) // 폰트 대화상자 호출
            {
                this.txtNote.Font = this.fdText.Font; // 텍스트 박스의 폰트 변경
            }
        }
    }
}