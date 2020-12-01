using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SWII_TP01.Dao {
    class CsvManager {

        private List<Model.Book> listOfBooks;

        private StreamReader bookFile;
        private StreamReader authorsFile;

        public CsvManager() {
            this.bookFile = new StreamReader("books.csv");
            this.authorsFile = new StreamReader("C:\\Users\\gabri\\source\\repos\\SWII-TP01\\SWII-TP01\\repositorio\\authors.csv");

            String lineBuffer = this.authorsFile.ReadLine();
            String[] objectBuffer = lineBuffer.Split(';');
           
    }

        public void Insert(Model.Book b) {
            String authorBuffer = new String("");
            foreach (Model.Author author in b.getAuthors()) {
                authorBuffer += author.getId()+";"+author.getName() + ";" + author.getEmail() + ";" + author.getGender() + ";" + b.getId() + "\n";
            }
         

            String bookBuffer = b.getId()+";"+b.getName()+";"+b.getPrice()+";"+b.getQuantity() + "\n";
       
        }

        public void Update(Model.Book book) {
            //foreach () { 
            
            //}
        }

        public Boolean Delete(Model.Book book) {
            return false;
        }

        public Model.Book GetByName(String searchBookName) {
            foreach (Model.Book book in this.listOfBooks) {
                if (book.getName().Equals(searchBookName)) {
                    return book;
                }
            }
            return null;
        }
    }
}
