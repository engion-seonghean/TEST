using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTGIT
{
    public partial class Form1 : Form
    {
        //pull -원격 저장소의 내용을 가져와 자동으로 병합 작업을 실행
        //fetch 단순히 원격 저장소의 내용을 확인만 하고 로컬 데이터와 병합은 하고 싶지 않은 경우
        //push, 로컬 저장소의 데이터를 원격 저장소로 밀어넣기

        //m`mod
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
