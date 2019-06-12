using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        string strName;
        string strAge;
        string strWork; // 나이, 이름, 직업 저장
        public Form1()
        {
            InitializeComponent();
        }
        bool TectCheck() {
            if (this.txtName.Text == "") {
                MessageBox.Show("이름을 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtName.Focus();
            }
            if (this.txtWork.Text == "") {
                MessageBox.Show("나이를 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAge.Focus();
            }
            if (this.txtWork.Text == "")
            {
                MessageBox.Show("나이를 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtWork.Focus();
                return false;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
