using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace G23W10WFCardDealer {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void OnDeal(object sender, EventArgs e) {
            Random r = new Random();

            // 0 ~ 51
            int n = r.Next(52);

            Image? img = Properties.Resources.ResourceManager
                            .GetObject(GetCardName(n)) as Image;

            card1.Image = img;
        }

        protected string GetCardName(int c) {
            string suit = string.Empty;
            switch (c / 13) {
                case 0: suit = "spades"; break;
                case 1: suit = "diamonds"; break;
                case 2: suit = "hearts"; break;
                case 3: suit = "clubs"; break;
                default: suit = "error"; break;
            }

            string rank = string.Empty;
            switch (c % 13) {
                case 0: rank = "ace"; break;
                case int n when (n > 0 && n < 10):
                    rank = (c % 13 + 1).ToString(); break;
                case 10: rank = "jack"; break;
                case 11: rank = "queen"; break;
                case 12: rank = "king"; break;
                default: rank = "error"; break;
            }

            //return rank + "_of_" + suit;
            //return string.Format("{0}_of_{1}", rank, suit);
            return $"{rank}_of_{suit}";
        }
    }
}