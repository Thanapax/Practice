class program {
    static void Main(string[] args){
        //one();
        //two();
        //three();
        //four();
        //five();
        //six();
        //seven();
        //eight();
        //nine();
        //ten(); //ผู้ใช้กรอกข้อมูลนำเข้าที่ไม่ใช่จำนวนเต็ม ให้แสดงผลลัพธ์เป็นข้อความว่า “Please input an integer.”
        //eleven();
        //twelve();
        fourteen();


    }
    static void one(){
        Console.Write("Please input number1 : ") ;
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Please input number2 : ") ;
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Please input number3 : ") ;
        int num3 = int.Parse(Console.ReadLine());

        int sum = num1 + num2 + num3 ;
        Console.WriteLine("Sum : {0}", sum) ;
        }  
    static void two(){
        Console.Write("please input a : ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("please input b : ");
        double b = double.Parse(Console.ReadLine());

        if (b >= a){
            Console.Write("please input x : ");
            double x = double.Parse(Console.ReadLine());

            if (x >= a && x <= b){
            Console.WriteLine(true);
            } else {
            Console.WriteLine(false);
            }
        } else {
            Console.WriteLine(false);
        }
        
    }
    static void three(){
        Console.Write("please input power number : ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine(Math.Pow(2,a));
        /* int b = 2 ;

        while(a > 1){
            b = b * 2 ;
            a--;
        } Console.WriteLine(b); */

        // int b = 1;
        // b = b << a ;
        // Console.WriteLine(b);
        
    }
    static void four(){
        Console.Write("input number : ");
        int a = int.Parse(Console.ReadLine());

        if (a >= 0){
            Console.WriteLine(a);
        } else {
            Console.WriteLine(Math.Abs(a));
        }

        
    }
    static void five(){

        int a = int.Parse(Console.ReadLine());
       
        Console.WriteLine(a++ % 8 + 1);
        // a++;
        Console.WriteLine(a++ % 8 + 1);
        // a++;
        Console.WriteLine(a++ % 8 + 1);
        // a++;
        Console.WriteLine(a++ % 8 + 1);
        // a++;

       
        /* int b = 1;
        int y = 0;
        Console.Write("Input num : ") ;
        int a = int.Parse(Console.ReadLine());
        while(y < 4){ 
             y++;
             if(a < 8){
                Console.WriteLine(a + 1);
                a++;
             } else{
                Console.WriteLine(b);
                b++;
             }
        } */
    }
    static void six(){
        Console.Write("Please input a number of stations: ");
        int a = int.Parse(Console.ReadLine());
        if (a == 1){
            Console.WriteLine("Cost (THB): 16");
        } if (a == 2){
            Console.WriteLine("Cost (THB): 23");
        } if (a == 3){
            Console.WriteLine("Cost (THB): 26");
        } if (a == 4){
            Console.WriteLine("Cost (THB): 30");
        } if (a == 5){
            Console.WriteLine("Cost (THB): 33");
        } if (a == 6){
            Console.WriteLine("Cost (THB): 37");
        } if (a == 7){
            Console.WriteLine("Cost (THB): 40");
        } if (a >= 8 && a <= 15){
            Console.WriteLine("Cost (THB): 44");
        } if (a > 15 ){
            Console.WriteLine("Cost (THB): 59");
        }

    }
    static void seven(){
        Console.Write("Pls input years : ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Pls input month : ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Pls input date : ");
        int c = int.Parse(Console.ReadLine());


        if (b <= 12 && c <= 31 && a >= 1868 ){

            if(a >= 1868 && b >= 9 && c >= 8 && a <= 1912){
                Console.WriteLine("Meiji");
            } else if(a > 1868 && a <= 1912){
                Console.WriteLine("Meiji");
            }

            if(a >= 1912 && b >= 7 && c >= 30 && a <= 1926){
                Console.WriteLine("Taisho");
            } else if(a > 1912 && a <= 1926){
                Console.WriteLine("Taisho");
            }
            
            if(a >= 1926 && b >= 12 && c >= 25 && a <= 1989){
                Console.WriteLine("Shouwa");
            } else if(a > 1926 && a <= 1989){
                Console.WriteLine("Shouwa");
            }

            if(a >= 1989 && b >= 1 && c >= 8 && a <= 2019){
                Console.WriteLine("Heisei");
            } else if(a > 1989 && a <= 2019){
                Console.WriteLine("Heisei");
            }

            if(a >= 2019 && b >= 5 && c >= 1 && a <= 2023){
                Console.WriteLine("Reiwa");
            } else if(a > 2019 && a <= 2023){
                Console.WriteLine("Reiwa");
            }
        } else {
            Console.WriteLine(false);
        }

    }
    static void eight(){
        Console.Write("Input number : ");
        int a = int.Parse(Console.ReadLine());

        switch(a){
            case 1 :
                Console.WriteLine("Yellow");
            break;
            case 2 :
                Console.WriteLine("Orange");
            break;
            case 3 :
                Console.WriteLine("Yellow");
                Console.WriteLine("Orange");
            break;
            case 4 :
                Console.WriteLine("Red");
            break;
            default:
                Console.WriteLine("Yellow");
                Console.WriteLine("Orange");
                Console.WriteLine("Red");
            break;
        }
    }
    static void nine(){
        Console.Write("Pls input amount : ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Pls input per : ");
        double b = double.Parse(Console.ReadLine());
        
        double Lapee = (100 * a) / (a * 2);
        double Shopzada = 100 * ((100 - b )/ 100);
        // double Shopzada = ((100 * a) * ((100 - b) / 100)) / a;

        Console.WriteLine("Lapee = {0}", Lapee);
        Console.WriteLine("Shopzada = {0}", Shopzada);

        if (Lapee > Shopzada){
            Console.WriteLine("Shopzada");
        } else if (Shopzada > Lapee){
            Console.WriteLine("Lapee");
        } else {
            Console.WriteLine("E-mazon");
        }
    }
    static void ten(){
        Console.Write("Input : ");
        int a = int.Parse(Console.ReadLine());
        
        if(a % 2 == 0 && a > 0){
            int b = a / 2 ;
            Console.WriteLine("{0}, {1}", b, b+1) ;
        }else if(a <= 0){
            Console.WriteLine("Please input a positive integer.") ;
        } else if (a % 2 != 0){
            Console.WriteLine("Please input an even positive integer.") ;
        } else {
            Console.WriteLine("Please input an integer.") ;
        }
    }
    static void eleven(){
        for(int a = int.Parse(Console.ReadLine()); a > 0 ; a--){Console.WriteLine("Hamlet");}
        /* while(a > 0){
            Console.WriteLine("Hamlet");
            a--;
        } */

    }
    static void twelve(){

    }
    static void fourteen(){
        int b = 5;
        for (int i = b ; i >= 0 ; i--){
            for(int j = 1 ; j <= i; j++){
                Console.Write("# ");
            }
            Console.WriteLine("0");
        }
        /* for(int row = 1; row <= b ; row++){
            for(int col = 1 ; col <= row ; col++){
                Console.Write("# ");
            }
            Console.WriteLine("1");
        }  */
        
    }
}