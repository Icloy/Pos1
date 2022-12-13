using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class ORDER
    {
        // 각 메뉴 하나당 곱해야할 가격 종류
        private int won1500 = 1500, won2000 = 2000, won2500 = 2500, won4500 = 4500, won15000 = 15000;
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
            nonsum = noncount * won4500;
            return nonsum;
        }

        public int ChamSum()
        {
            chamsum = chamcount * won4500;
            return chamsum;
        }

        public int FreshSum()
        {
            freshsum = freshcount * won4500;
            return freshsum;
        }

        public int StartSum()
        {
            startsum = startcount * won4500;
            return startsum;
        }
        public int JinroSum()
        {
            jinrosum = jinrocount * won4500;
            return jinrosum;
        }

        public int CassSum()
        {
            casssum = casscount * won4500;
            return casssum;
        }

        public int HiteSum()
        {
            hitesum = hitecount * won4500;
            return hitesum;
        }

        public int TerraSum()
        {
            terrasum = terracount * won4500;
            return terrasum;
        }

        public int ChunghaSum()
        {
            chunghasum = chunghacount * won4500;
            return chunghasum;
        }

        public int ColaSum()
        {
            colasum = colacount * won2000;
            return colasum;
        }

        public int CiderSum()
        {
            cidersum = cidercount * won2000;
            return cidersum;
        }

        public int FantaSum()
        {
            fantasum = fantacount * won2000;
            return fantasum;
        }


        public int SumCash() // 총 금액
        {
            sumcash = chamsum + freshsum + startsum + jinrosum + casssum + hitesum + terrasum + chunghasum + colasum + cidersum + fantasum;
            return sumcash;
        }
    }
}
