using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaciObjektno1
{
    class Sport
    {
        private string Naziv;
        private bool IgraLiSeLoptom;
        private byte BrojIgraca;


        public Sport(string s)     
        {   
            Naziv = s;     
        
        } 
        public Sport(string s, bool b)     
        {   
            Naziv = s;         
            IgraLiSeLoptom = b;     
        } 
        public Sport(string s, bool b, byte n)     
        {   
            Naziv = s;         
            IgraLiSeLoptom = b;         
            BrojIgraca = n;     
        } 
    
    }
    
}
