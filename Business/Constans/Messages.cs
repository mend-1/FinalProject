using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constans
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MainteanceTime = "Sistem bakımda";
        public static string ProductsListed;
        public static string ProductCountOfCategoryError = "Kategorideki ürün miktarını aştınız";
        public static string CategoryAlreadyExistsError = "Bu isimden zaten ürün var";
        public static string CategoryLimitedExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";

        public static string ProductNameAlreadyExists= "Bu isimden zaten ürün var";
    }
}
