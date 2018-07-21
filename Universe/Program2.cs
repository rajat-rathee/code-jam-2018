using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using static System.Environment;
using System.Text.RegularExpressions;
class univ {
    static void Main(string[] args){
        //int numTrials = 0;
        int lineNum = 1;
        List<int> defense = new List<int>();
        List<String> commands = new List<String>();
        List<string> norm = new List<string>();
        List<int> indexLastShot = new List<int>();
        /*
        
        
        using (StreamReader reader = new StreamReader(Console.OpenStandardInput(), Console.InputEncoding)) ////INPUT
        {
            string line; 
            while((line = reader.ReadLine()) != null){
                norm.Add(line);
            }
        }
        for (int k=0; k<norm.Count; k++){
           string l = norm[k];
           norm[k] =  l.Replace(' ', '\n');
        }
       // norm.ForEach(Console.WriteLine);
        string[] fix = norm.ToArray();
        System.IO.File.WriteAllLines("input.txt", fix);
        
        using (StreamReader reader2 = new StreamReader("input.txt")) {
        
        
            string line;
            while((line = reader2.ReadLine()) != null){
                if(lineNum > 0){
                    if(lineNum % 2 == 0){
                        commands.Add(line);
                    } else {
                        defense.Add(int.Parse(line));
                    }
                } else {
                    numTrials = int.Parse(line);
                }
                lineNum++;
            }
        }
        */
        
        
        int numTrials = System.Int32.Parse(System.Console.ReadLine());
        
        for(lineNum = 1; lineNum <= numTrials;lineNum++){
            //if(lineNum % 2 == 0){
            string[] items = new string[2];
                items = (System.Console.ReadLine().Split());
                commands.Add(items[1]);
            //} else {
                defense.Add(int.Parse(items[0]));
            //}
        }
        
        //commands.ForEach(Console.WriteLine);
        //defense.ForEach(Console.WriteLine);
        int numMoves = 0;
        int numD = 0;
        int numS = 0;
        int damage = 0;
        int damagePerHit = 1;
        bool bestMove;
        for(int i = 0;i < numTrials; i++){
            numD = defense[i];
            for(int j = 0; j < commands[i].Length;j++){
                if("S" == commands[i].Substring(j,1)){
                    numS++;
                }
            }
            if(numS > numD){
                Console.WriteLine("Case #" + (i+1) + ": IMPOSSIBLE");
                numS = 0;
            } else {
                for(int j = 0; j < commands[i].Length;j++){
                    if("S" == commands[i].Substring(j,1)){
                        damage += damagePerHit; 
                    } else {
                        damagePerHit *= 2;
                    }
                }
                
                while(damage > numD){
                    damage = 0;
                    damagePerHit = 1;
                    for(int p = commands[i].Length - 1; p < commands[i].Length && p > 0; p--){
                        if("S" == commands[i].Substring(p,1)){
                            if("C" == commands[i].Substring((p-1),1)){
                                commands[i] = commands[i].Substring(0,p-1) + "SC" + commands[i].Substring(p+1,commands[i].Length-p-1);
                                p = commands[i].Length + 1;
                            }
                        }
                    }
                    for(int j = 0; j < commands[i].Length;j++){
                        if("S" == commands[i].Substring(j,1)){
                            damage += damagePerHit; 
                        } else {
                            damagePerHit *= 2;
                        }
                    }
                    numMoves++;
                }
                // 4 CSCS
                Console.WriteLine("Case #" + (i+1) + ": " + numMoves);
                numMoves = 0;
                damagePerHit = 1;
                numS = 0;
                damage = 0;
            }
        }
        
        
        
        
    }
}