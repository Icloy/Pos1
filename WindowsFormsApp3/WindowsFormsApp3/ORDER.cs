using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace WindowsFormsApp3
{
    
    class ORDER
    {
<<<<<<< HEAD

        // 각 메뉴 하나당 곱해야할 가격 종류
        private int won1500 = 1500, won2000 = 2000, won2500 = 2500, won4500 = 4500, won55000 = 55000, won39000 = 39000, won65000 = 65000, won73000 = 73000, won43000 = 43000, won38000 = 38000, won29000 = 29000, won21000 = 21000, won20000 = 20000;
=======
        private int SelectedRowIndex; //수정하거나 삭제하기 위해 선택된 행의 인덱스를 저장한다. 
        OracleDataAdapter DBAdapter; // Data Provider인 DBAdapter 입니다. 
        DataSet DS; // DataSet 객체입니다. 
        OracleCommandBuilder myCommandBuilder;
        DataTable ProductTable; // DataTable 객체입니다. 
        SqlCommand cmd;
        int countsum;
        int menusale;
        

        // 각 메뉴 하나당 곱해야할 가격 종류
        private int won1, won2, won3, won4, won5, won6, won11, won12, won13, won14, won15, won16, won21, won22, won23, won24, won25, won26;



>>>>>>> fc85160b13687ae2dcedffba2e8cfd434751f6dd
        // 각 메뉴별 갯수 카운트 (이제 수량이랑 금액 계산때문에 1로 둠)
        private int chamcoun = 1, freshcoun = 1, startcoun = 1, noncoun = 1, jinrocoun = 1, casscoun = 1, hitecoun = 1, terracoun = 1, chunghacoun = 1, colacoun = 1, cidercoun = 1, fantacoun = 1;
        private int meet1coun = 1, meet2coun = 1, meet3coun = 1, meet4coun = 1, meet5coun = 1, meet6coun = 1, meet7coun = 1, meet8coun = 1, meet9coun = 1;
        // 각 메뉴별 주문한 총 금액
        private int chammny = 0, freshmny = 0, startmny = 0, nonmny = 0, jinromny = 0, cassmny = 0, hitemny = 0, terramny = 0, chunghamny = 0, colamny = 0, cidermny = 0, fantamny = 0;
        private int meet1mny = 0, meet2mny = 0, meet3mny = 0, meet4mny = 0, meet5mny = 0, meet6mny = 0, meet7mny = 0, meet8mny = 0, meet9mny = 0;
        // 총 금액, 총 갯수
        private int test =0;




        public int sumnumber
        {
            get; set;
        }
        public int sumcash
        {
            get; set;
        }

        public int noncount
        {
            get { return noncoun; }
            set { noncoun = value; }
        }

        public int chamcount
        {
            get { return chamcoun; }
            set { chamcoun = value; }
        }

        public int freshcount
        {
            get { return freshcoun; }
            set { freshcoun = value; }
        }

        public int startcount
        {
            get { return startcoun; }
            set { startcoun = value; }
        }

        public int jinrocount
        {
            get { return jinrocoun; }
            set { jinrocoun = value; }
        }

        public int casscount
        {
            get { return casscoun; }
            set { casscoun = value; }
        }

        public int hitecount
        {
            get { return hitecoun; }
            set { hitecoun = value; }
        }

        public int terracount
        {
            get { return terracoun; }
            set { terracoun = value; }
        }

        public int chunghacount
        {
            get { return chunghacoun; }
            set { chunghacoun = value; }
        }

        public int colacount
        {
            get { return colacoun; }
            set { colacoun = value; }
        }

        public int cidercount
        {
            get { return cidercoun; }
            set { cidercoun = value; }
        }

        public int fantacount
        {
            get { return fantacoun; }
            set { fantacoun = value; }
        }

        public int meet1count
        {
            get { return meet1coun; }
            set { meet1coun = value; }
        }

        public int meet2count
        {
            get { return meet2coun; }
            set { meet2coun = value; }
        }

        public int meet3count
        {
            get { return meet3coun; }
            set { meet3coun = value; }
        }

        public int meet4count
        {
            get { return meet4coun; }
            set { meet4coun = value; }
        }

        public int meet5count
        {
            get { return meet5coun; }
            set { meet5coun = value; }
        }

        public int meet6count
        {
            get { return meet6coun; }
            set { meet6coun = value; }
        }

        public int meet7count
        {
            get { return meet7coun; }
            set { meet7coun = value; }
        }

        public int meet8count
        {
            get { return meet8coun; }
            set { meet8coun = value; }
        }

        public int meet9count
        {
            get { return meet9coun; }
            set { meet9coun = value; }
        }


        // 메뉴들 금액

        public int nonsum
        {
            get { return nonmny; }
            set { nonmny = value; }
        }

        public int chamsum
        {
            get { return chammny; }
            set { chammny = value; }
        }

        public int freshsum
        {
            get { return freshmny; }
            set { freshmny = value; }
        }

        public int startsum
        {
            get { return startmny; }
            set { startmny = value; }
        }
        public int jinrosum
        {
            get { return jinromny; }
            set { jinromny = value; }
        }

        public int casssum
        {
            get { return cassmny; }
            set { cassmny = value; }
        }

        public int hitesum
        {
            get { return hitemny; }
            set { hitemny = value; }
        }

        public int terrasum
        {
            get { return terramny; }
            set { terramny = value; }
        }

        public int chunghasum
        {
            get { return chunghamny; }
            set { chunghamny = value; }
        }

        public int colasum
        {
            get { return colamny; }
            set { colamny = value; }
        }

        public int cidersum
        {
            get { return cidermny; }
            set { cidermny = value; }
        }

        public int fantasum
        {
            get { return fantamny; }
            set { fantamny = value; }
        }

        public int meet1sum
        {
            get { return meet1mny; }
            set { meet1mny = value; }
        }

        public int meet2sum
        {
            get { return meet2mny; }
            set { meet2mny = value; }
        }

        public int meet3sum
        {
            get { return meet3mny; }
            set { meet3mny = value; }
        }

        public int meet4sum
        {
            get { return meet4mny; }
            set { meet4mny = value; }
        }

        public int meet5sum
        {
            get { return meet5mny; }
            set { meet5mny = value; }
        }

        public int meet6sum
        {
            get { return meet6mny; }
            set { meet6mny = value; }
        }

        public int meet7sum
        {
            get { return meet7mny; }
            set { meet7mny = value; }
        }

        public int meet8sum
        {
            get { return meet8mny; }
            set { meet8mny = value; }
        }

        public int meet9sum
        {
            get { return meet9mny; }
            set { meet9mny = value; }
        }
        

        // 메뉴들 총금액을 계산해서 반환해주는 메소드
        public int NonSum()
        {
            nonsum = noncount;
            return nonsum;
        }

        public int ChamSum()
        {
            chamsum = chamcount * menusale;
            return chamsum;
        }

        public int FreshSum()
        {
            freshsum = freshcount * menusale;
            return freshsum;
        }

        public int StartSum()
        {
            startsum = startcount;
            return startsum;
        }
        public int JinroSum()
        {
            jinrosum = jinrocount;
            return jinrosum;
        }

        public int CassSum()
        {
            casssum = casscount;
            return casssum;
        }

        public int HiteSum()
        {
            hitesum = hitecount;
            return hitesum;
        }

        public int TerraSum()
        {
            terrasum = terracount;
            return terrasum;
        }

        public int ChunghaSum()
        {
            chunghasum = chunghacount;
            return chunghasum;
        }

        public int ColaSum()
        {
            colasum = colacount;
            return colasum;
        }

        public int CiderSum()
        {
            cidersum = cidercount;
            return cidersum;
        }

        public int FantaSum()
        {
            fantasum = fantacount;
            return fantasum;
        }

        public int Meet1Sum()
        {
            meet1sum = meet1count * won55000;
            return meet1sum;
        }

        public int Meet2Sum()
        {
            meet2sum = meet2count * won39000;
            return meet2sum;
        }

        public int Meet3Sum()
        {
            meet3sum = meet3count * won65000;
            return meet3sum;
        }

        public int Meet4Sum()
        {
            meet4sum = meet4count * won73000;
            return meet4sum;
        }

        public int Meet5Sum()
        {
            meet5sum = meet5count * won43000;
            return meet5sum;
        }

        public int Meet6Sum()
        {
            meet6sum = meet6count * won38000;
            return meet6sum;
        }

        public int Meet7Sum()
        {
            meet7sum = meet7count * won20000;
            return meet7sum;
        }

        public int Meet8Sum()
        {
            meet8sum = meet8count * won29000;
            return meet8sum;
        }

        public int Meet9Sum()
        {
            meet9sum = meet9count * won21000;
            return meet9sum;
        }

        public int SumCash() // 총 금액
        {
            sumcash = chamsum + freshsum + startsum + jinrosum + casssum + hitesum + terrasum + chunghasum + colasum + cidersum + fantasum + meet1sum + meet2sum + meet3sum + meet4sum + meet5sum + meet6sum + meet7sum
                 + meet8sum + meet9sum ;
            return sumcash;
        }


    }
}
