using System.Text.Json  // джейсон файл
class dumper{
    private String filename;  
    private String filetype;
    private String filepath;
     void save() {
       string JsonString = JsonSerializer.Serialize(dump);
        
    }
}