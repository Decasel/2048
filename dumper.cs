using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Collections.Specialized;
using System.Text;
using System.IO;
using System.Text.Json;  // джейсон файл
class dumper
{

    private String filename;
    private String[] filetype = { ".bin", ".json", ".txt" };
    private String filepath;
    private dump dmp;

    private bool saveMode = true; //true - text, false - binary
    private int curSaveType; //Index of filetype 

    public dumper(String f_name, String f_path, int f_type)
    { //Конструктор для записи текстом
        saveMode = true;
        if (f_type > -1 && f_type < filetype.Length)
        {
            curSaveType = f_type;
        }
        else
        {
            curSaveType = 1;
        }

        filename = f_name;
        filepath = f_path;


    }

    public dumper(String f_name, String f_path)
    { //Конструктор для записи бинарным видом
        saveMode = false;
        filename = f_name;
        filepath = f_path;
    }

    public void setDump(dump d)
    {
        dmp = d;
    }

    public dump getDump() { return dmp; }

    public async void writeProgress()
    {
        String fullFileName = filepath + filename + filetype[curSaveType];
        String contanerJson = JsonSerializer.Serialize(dmp);
        if (File.Exists(fullFileName))
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(fullFileName, false);
            await
          file.WriteAsync(contanerJson);
            file.Close();
        }
        else
        {
            File.Create(fullFileName).Close();
            System.IO.StreamWriter file = new System.IO.StreamWriter(fullFileName, false);
            await
            file.WriteAsync(contanerJson);
            file.Close();
        }
    }

    public async void readProgress()
    {
        String fullFileName = filepath + filename + filetype[curSaveType];
        if (File.Exists(fullFileName))
        {
            StreamReader sr = File.OpenText(fullFileName);
            String json = "";
            String s = "";

            while ((s = sr.ReadLine()) != null)
            {
                json += s;
            }
            sr.Close();
            dmp = JsonSerializer.Deserialize<dump>(json);
        }
        else
        {
            File.Create(fullFileName).Close();
            writeProgress();
        }
    }

}