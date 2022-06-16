namespace ConsoleApp2
{
    class Citizen
    { 
        public Citizen()
        {
            _totalCount++;
            _serialNo = "AZE" + _totalCount;
        }
        public string Name;
        public string Soyad;
        private string _serialNo;
        public string SerialNo => _serialNo;
        private static int _totalCount = 1000;

       
        
    }
}
