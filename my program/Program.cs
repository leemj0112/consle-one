
namespace my_program
{
    class GiftBox
    {
        public string Letter;
        public int Money;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            GiftBox addressA = GiftBoxMaker("A친구야 잘 지내지?", 110000);
            GiftBox addressB = GiftBoxMaker("B친구야 잘 지내지?", 120000);
            GiftBox addressC = GiftBoxMaker("C친구야 잘 지내지?", 130000);

            GiftBox[] giftBoxes = new GiftBox[3];
            GiftBox giftBox = giftBoxes[0];
            giftBoxes[0] = addressA;
            giftBoxes[1] = addressB;
            giftBoxes[2] = addressC;
            Console.WriteLine("giftBox Array Count : " + giftBoxes.Length);

            //List
            List<GiftBox> giftBoxList = new List<GiftBox>();
            giftBoxList.Add(addressA);  //0
            giftBoxList.Add(addressB);  //1
            giftBoxList.Add(addressC);  //2

            Console.WriteLine(giftBoxList[2].Letter);
            Console.WriteLine("giftBox List Count : " + giftBoxList.Count);
        }

        private static GiftBox GiftBoxMaker(string Letter, int Money)
        {
            GiftBox addressA = new GiftBox()
            {
                Letter = Letter,
                Money = Money
            };
            return addressA;
        }
    }
}
