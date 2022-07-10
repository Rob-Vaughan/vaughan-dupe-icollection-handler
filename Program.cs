using Vaughan_Generic_Duplicate_Handler;



List<string> islandList = new List<string>() 
    {
        "O'ahu", 
        "Maui", 
        "Hawai'i", 
        "Hawai'i", 
        "Moloka'i", 
        "Lana'i", 
        "Lana'i", 
        "Lana'i", 
        "Ni'ihau", 
        "Kaho'olawe" 
    };
var cleanIslands = (List<string>)GenericDuplicateHandler.removeDuplicates<string>(islandList);
foreach (var item in cleanIslands)
    Console.WriteLine(item);

List<string> newListString = new List<string>
     {
         "Hello",
         "World",
         "Hello",
         "Hello"
     };
var cleanList = (List<string>)GenericDuplicateHandler.removeDuplicates<string>(newListString);
foreach (var item in cleanList)
    Console.WriteLine(item);

List<int> newListInt = new List<int>
     {
         1,2,3,4,5,1,2,3,3
     };
var cleanInt = (List<int>)GenericDuplicateHandler.removeDuplicates<int>(newListInt);
foreach (var item in cleanInt)
    Console.WriteLine(item);

List<Page> newListObj = new List<Page>();
Page newPage = new Page
    {
        Id = 1,
        FileName = "TestFile.txt",
        DocumentType = "TestDocType",
        ImportDate = DateTime.Now,
        PageNumber = 1
    };
newListObj.Add(newPage);
newListObj.Add(newPage);
newListObj.Add(newPage);
var cleanObj = (List<Page>)GenericDuplicateHandler.removeDuplicates<Page>(newListObj);
foreach (var item in cleanObj)
    Console.WriteLine(item);

Console.ReadKey(true);
