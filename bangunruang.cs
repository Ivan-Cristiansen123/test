using System;

namespace helloworld{

    class bangunruang
    {
        public int Volume_balok(int panjang, int lebar, int tinggi )
        {
            return  panjang * lebar * tinggi;
        }
    
         public void volume_kubus(int sisi )
        {
            Console.WriteLine("luas persegi adalah "+sisi * sisi * sisi);
        }
    
    }
}