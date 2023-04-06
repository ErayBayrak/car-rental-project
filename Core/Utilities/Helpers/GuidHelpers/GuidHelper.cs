using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers.GuidHelpers
{
    public class GuidHelper
    {
        //burada yüklediğimiz dosyamız için eşsiz bir isim oluşturduk.
        //Yani dosya eklerken dosyanın adı kendi olmasın,
        //biz ona eşsiz bir isim oluşturalım ki aynı isimde başka bir dosya varsa çakışmasınlar.
        //Guid.NewGuid()=> bu metot bize eşsiz bir değer oluşturdu.
        //ToString()=> bununlada string hale getirdik.
        public static string CreateGuid()
        {
            return Guid.NewGuid().ToString();  
        }
    }
}
