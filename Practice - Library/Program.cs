

// Example of creating and displaying book objects

using Practice___Library;

Library book1 = new Library();
book1 = new Library("Adı Aylin","Ayşe", "Kulin",398,"Remzi Kitabevi");

Library book2 = new Library();
book2 = new Library("Bir Kitap", "Ayşe", "Yılmaz", 320, "Alfa Yayınları");

Library book3 = new Library();
book3.bookName = "Kaderin Çocukları";
book3.authorName = "Darren";
book3.authorSurname = "Shan";
book3.page = 200;
book3.publisher = "Tudem";


book1.DisplayProduct();
book2.DisplayProduct();
book3.DisplayProduct();


/*
Kodlarınızın altına birer yorum satırıyla örnek üzerinden Class , Property , New , Constructor kavramlarını açıklayınız.
  
   * Class :  Verileri ve fonksiyonları içeren alandır. Bu örnekte değişkenleri ve bu değişkenlerle işlem yapan metotları içeren yapıdır.
   * Property :  Field'ların dışarıdan erişilebilmesini kontrol etmeye yarar. Bu örnekte private olan değişkenleri property kullanılarak erişilebilir yapıldı.
   * New : OOP'de yeni bir nesne oluşturmak için kullanılan anahtardır.
   * Constructor : Sınıf içinde kullanılan bir nesnenin yapısını oluşturan yapıcı methoddur.
   

   * Class: A structure that contains data and functions. In this example, it is the structure that includes variables and methods that operate on these variables.
   * Property: Allows controlled access to the fields. In this example, properties are used to make private variables accessible.
   * New: The keyword used to create a new instance of an object in OOP (Object-Oriented Programming).
   * Constructor: A special method used to set up the structure of an object within a class.
*/
