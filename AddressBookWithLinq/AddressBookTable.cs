using System;
using System.Data;

namespace AddressBookWithLinq
{
    internal class AddressBookTable
    {
        public AddressBookTable()

        {
        }
        private readonly DataTable dataTable = new DataTable();

        /// <summary>
        /// Creates the Address Book table and added the new contact into the table.
        /// </summary>
        public void createTable()
        {
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("State", typeof(string));
            dataTable.Columns.Add("ZipCode", typeof(int));
            dataTable.Columns.Add("PhoneNumber", typeof(long));
            dataTable.Columns.Add("Email", typeof(string));

            dataTable.Rows.Add("varni", "hudge", "tawarja", "latur", "maharashtra", 413512, 9949713160, "varni@gmail.com");
            dataTable.Rows.Add("sabi", "hudge", "mataji", "pune", "karnataka", 413512, 8949713160, "sabi@gmail.com");
            dataTable.Rows.Add("anu", "shinde", "tawarja", "delhi", "maharashtra", 413512, 9149713160, "anu@gmail.com");
            dataTable.Rows.Add("aarthi", "kumar", "mataji", "latur", "maharashtra", 413512, 6149713160, "aarthi@gmail.com");
            dataTable.Rows.Add("abi", "munde", "gandhi chowk", "beed", "up", 413562, 9148713160, "rahul@gmail.com");
            dataTable.Rows.Add("varun", "huge", "adarsh colony", "latur", "maharashtra", 463512, 8149713160, "kunal@gmail.com");
            dataTable.Rows.Add("anithia", "yede", "tawarja", "usmanabad", "maharashtra", 413512, 8149913160, "prince@gmail.com");
            dataTable.Rows.Add("akash", "pawar", "tawarja", "mumbai", "kerala", 413512, 8146713160, "akash@gmail.com");
            dataTable.Rows.Add("priya", "kumar", "tawarja", "latur", "maharashtra", 413512, 8149713160, "priya@gmail.com");
            dataTable.Rows.Add("rokul", "pande", "tawarja", "chakur", "chenni", 413512, 8149713160, "rokul@gmail.com");
        }

        /// <summary>
        /// Displays the address book.
        /// </summary>
        public void displayAddressBook()
        {
            foreach (var table in dataTable.AsEnumerable())
            {
                Console.WriteLine("\nFirstName:-" + table.Field<string>("FirstName"));
                Console.WriteLine("LastName:-" + table.Field<string>("LastName"));
                Console.WriteLine("Address:-" + table.Field<string>("Address"));
                Console.WriteLine("City:-" + table.Field<string>("City"));
                Console.WriteLine("State:-" + table.Field<string>("State"));
                Console.WriteLine("ZipCode:-" + table.Field<int>("ZipCode"));
                Console.WriteLine("PhoneNumber:-" + table.Field<long>("PhoneNumber"));
                Console.WriteLine("Email:-" + table.Field<string>("Email"));
            }
        }
    }
}
