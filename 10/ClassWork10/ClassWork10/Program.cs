using System;

namespace ClassWork10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point point = new Point();
            //point.X = 1.0F;
            //point.Y = -1.5F;
            //point.Color = "red";

            //Point point2 = new Point();
            //Console.WriteLine(point == point2);

            Wallet myWallet = new Wallet();
            //myWallet.DollarsAmount = 100;
            //myWallet.RublesAmount = 6289.25M;
            myWallet.AddDollars(100);

            Console.WriteLine(myWallet.GetRubles());

            //decimal ratio = myWallet.RublesAmount / myWallet.DollarsAmount;
            //myWallet.RublesAmount -= 50;
            //myWallet.DollarsAmount -= 50 * ratio;
        }
    }
    class Point
    {
        public float X;
        public float Y;
        public string Color;
    }
    //class Wallet
    //{
    //    private decimal _money;
    //    private const decimal _rublesRatio = 10;
    //    private const decimal _dollarsRatio = 628.925M;

    //    public decimal DollarsAmount;
    //    public decimal RublesAmount;

    //    public decimal GetRubles()
    //    {
    //        return _money / _rublesRatio;

    //    }
    //    public decimal GetDollars()
    //    {
    //        return _money / _dollarsRatio;

    //    }
    //    public void AddRubles(decimal rublesToAdd)
    //    {
    //        _money += rublesToAdd * _rublesRatio;
    //    }
    //    public void AddDollars(decimal dollarsToAdd)
    //    {
    //        _money += dollarsToAdd * _dollarsRatio;
    //    }

    class Wallet
    {
        private decimal _money;
        private const decimal _rublesRatio = 10;
        private const decimal _dollarsRatio = 628.925M;

        public decimal DollarsAmount;
        public decimal RublesAmount;

        public decimal GetRubles()
        {
            return _money / _rublesRatio;

        }

        public void AddRubles(decimal rublesToAdd)
        {
            _money += rublesToAdd * _rublesRatio;
        }

        public decimal Rubles
        {
            get { return _money / _rublesRatio; }
            set { _money = value * _rublesRatio; }
        }

        public decimal GetDollars()
        {
            return _money / _dollarsRatio;

        }
        
        public void AddDollars(decimal dollarsToAdd)
        {
            _money += dollarsToAdd * _dollarsRatio;
        }


    }
}
