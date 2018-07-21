using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
class end {
    static void Main(String[] args) {
        List<int> list = new List<int>();
        List<string> end = new List<string>();
        using (StreamReader reader = new StreamReader("inputend.txt")) //INPUT
        {
            string line;
            while((line = reader.ReadLine()) != null){
                end.Add(line);
            }
        }
        int r = end.Count;


        
        
        for(int k=0; k<r; k++){
            string l =  end[k];
            end[k]= l.Replace(' ', '\n');
        }
        string[] fix = end.ToArray();
        
        System.IO.File.WriteAllLines("inputend.txt", fix);
        using (StreamReader reader = new StreamReader("inputend.txt")) //INPUT
        {
            string line2;
            while((l
            ine2 = reader.ReadLine()) != null){
                list.Add(int.Parse(line2));
                }
        }
        
        int counter = 0;
        int threetemp = 2;
        bool yeet = false;
        bool changed = false;
        int totalCases = list[0];
        
        
        for(int z = 0; z < totalCases;z++){
            int numOfNums = list[z + 1];
            List<int> cList = new List<int>();
            for(int i = 0; i < numOfNums; i++) {
                
            }
            yeet = false;
            changed = false;
            while(!yeet) {
                counter = 0;
                threetemp = 2;
                while(threetemp < list.Count) {
                    changed = false;
                    if(list[counter] > list[threetemp]) {
                        
                        int ftemp = list[counter];
                        int stemp = list[threetemp];
                        list[counter] = stemp;
                        list[threetemp] = ftemp;
                        changed = true;
        
                    }
                    
                    counter ++;
                    threetemp ++;
                    
                }
                if(!changed) {
                    yeet = true;
                }
            }
            
            
        
        counter = 0;
        int tempCounter = 1;
        int findex = -1;
        bool yeeet = false;
        while(tempCounter < list.Count) {
            int temP = list[counter];
            int tempP = list[tempCounter];
            if(temP > tempP) {
                findex = counter;
                yeeet = true;
                break;
            }
            counter++;
            tempCounter++;
            
        }
        
        if(!yeeet) {
            Console.WriteLine("Case #" + (z+1) + ": OK");
        } else {
            Console.WriteLine("Case #" + (z+1) + ": " + findex);
        }
        }
    }
    
    
}