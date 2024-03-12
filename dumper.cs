using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Collections.Specialized;
using System.Text;
using System.Text.Json;  // джейсон файл
class dumper{

  private String filename;  
  private String[] filetype = {".bin", ".json", ".txt"};
  private String filepath;

  private dump dmp;

  private bool saveMode = true; //true - text, false - binary
  private int curSaveType; //Index of filetype 

  public dumper(dump d, String f_name, String f_path, int f_type){ //Конструктор для записи текстом
    saveMode = true;
    if(f_type > -1 && f_type < filetype.Length){
      curSaveType = f_type;
    }else{
      curSaveType = 1;
    }

    filename = f_name;
    filepath = f_path;
    dmp = d;

  }

  public dumper(dump d, String f_name, String f_path){ //Конструктор для записи бинарным видом
    saveMode = false;
    filename = f_name;
    filepath = f_path;
        dmp = d;
    }

  void save() { // Сохраняет JSON
    String JsonString = JsonSerializer.Serialize(dmp);
        
  }

  dump read(){ // Читает JSON

        return null;

  }

    // ...........................................................
    //public async void writeProgress()
    //{
    //    contanerJson =
    //      JsonSerializer.Serialize(progr);
    //    if (File.Exists(filename))
    //    {
    //        System.IO.StreamWriter file = new
    //        System.IO.StreamWriter(fileName, false);
    //        await
    //      file.WriteAsync(contanerJson);
    //        File.Close();
    //    }
    //    else
    //    {
    //        File.Create(fileName).Close();
    //        System.IO.StreamWriter file = new
    //          System.IO.StreamWriter(fileName, false);
    //        await
    //        file.WriteAsync(contanerJson);
    //        file.Close();
    //    }
    //}
    //
    //public void Progress()
    //{
    //    if (File.Exists(fileName))
    //    {
    //        StreamReader sr =
    //          File.OpenText(fileName);
    //        String json = "";
    //        String s = "";
    //        while ((s = sr.ReadLine()) !=
    //        null)
    //        {
    //            json += s;
    //        }
    //        sr.Close();
    //        progr =
    //    JsonSerializer.Drserialize<Params>(Json);
    //    }
    //    else
    //    {
    //        File.Create(fileName).Close();
    //        writeProgress();
    //    }
    //}
    // ...........................................................
}