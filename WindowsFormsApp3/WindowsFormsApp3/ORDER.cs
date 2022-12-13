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



        // 각 메뉴별 갯수 카운트 (이제 수량이랑 금액 계산때문에 1로 둠)
        private int chamcoun = 1, freshcoun = 1, startcoun = 1, noncoun = 1, jinrocoun = 1, casscoun = 1, hitecoun = 1, terracoun = 1, chunghacoun = 1, colacoun = 1, cidercoun = 1, fantacoun = 1;
        // 각 음료별 주문한 총 금액
        private int chammny = 0, freshmny = 0, startmny = 0, nonmny = 0, jinromny = 0, cassmny = 0, hitemny = 0, terramny = 0, chunghamny = 0, colamny = 0, cidermny = 0, fantamny = 0;

        // 총 금액, 총 갯수




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


        public int SumCash() // 총 금액
        {
            sumcash = chamsum + freshsum + startsum + jinrosum + casssum + hitesum + terrasum + chunghasum + colasum + cidersum + fantasum;
            return sumcash;
        }
    }
}
