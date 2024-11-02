using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********programs Output********* ");
         

                 //* Consider first name as sathya and last name as technologies now print full name.
                 String first = "Sathya";
                 String last  = "technologies";
                 Console.WriteLine("(1).Full name is : " + first +" "+ last);
                 Console.ReadKey();
                 Console.WriteLine("========================================================================================================================================");
                 //===================================================================================
                 //* Consider a value as 5 and b Value is 7 now add , a&b store into c , then display c.
                 int a = 5;
                 int b = 7;
                 int c = a + b;
                 Console.WriteLine("(2).Added value is =" + c);
                 Console.ReadKey();
                 Console.WriteLine("==========================================================================================================================================");
                 //===================================================================================
                 //* write a program take j = 5.6 and k = 10.5 and display sum
                 double j = 5.6;
                 double k = 10.5;
                 double sum = j + k;
                 Console.WriteLine("(3).Sum is =" + sum);
                 Console.ReadKey();
                 Console.WriteLine("============================================================================================================================================");
                 //====================================================================================
                 //* write a program to consider l = 20 & m = 2.5 perform substraction 
                 int l = 20;
                 double m = 2.5;
                 double n = l - m;
                 Console.WriteLine("(4).Substraction is =" + n);
                 Console.ReadKey();
                 Console.WriteLine("============================================================================================================================================");
                 //===================================================================================
                 //* Consider Mr.vishnu annual salary is 6500000,now calculate his monthly salary.
                 int anual = 650000;
                 int day = 365;

                 double month = anual / 12;
                 double per = anual / day;
                 Console.WriteLine("(5).monthly salary is :-"+month);
                 Console.WriteLine("------Perday salary is :-" + per);
                 Console.ReadKey();
                 Console.WriteLine("=============================================================================================================================================");
                 //====================================================================================
                 //* consider mr.Shiva monthly salry is 35500.60 now Calculate his annual salary.
                 double mont = 35000.0;
                 double anu = mont * 12;
                 Console.WriteLine("(6).Annual Salary is :=" + anu);
                 Console.ReadKey();
                 Console.WriteLine("============================================================================================================================================");
                 //====================================================================================
                 //*ms laksmi Opened Swiggy observed  that Pizza Cost is 345.60, She orderd 3 pizza. 
                 // W.a.p To calculate her bill amt.swiggy added 20rs as service caharge and 30rs as tip so find toatal bill. 
                 double pcost = 345.60;
                 int order = 3;
                 double charg = 20;
                 double tip = 30;
                 double total = pcost * order + charg + tip;
                 Console.WriteLine("(7).Total Bill Amount is :-" + total);
                 Console.ReadKey();
                 Console.WriteLine("==============================================================================================================================================");
                 //======================================================================================================
                 //* Consider 3 Subject marks as 92,98,99. now calculate and avg Total marks .
                 int s1 = 92, s2 = 98, s3 = 99;
                 int totalm = s1+s2+s3;
                 double avg = totalm / 3;
                 Console.WriteLine("(8).Total marks is = "+totalm);
                 Console.WriteLine("------------average  marks is = " + avg);
                 Console.ReadKey();
                 Console.WriteLine("=============================================================================================================================================");
                 //======================================================================================================
                 //* consider celcious temprature 32 degree now convert into  faranhight 
                 int ce = 36;
                 double feranhight = ((ce * 9) / 5) + 32;
                 Console.WriteLine("(9).tempreture in celcious :="+ce+" "+ "Celcious temrature is Converted into faranhigth = " + feranhight);
                 Console.ReadKey();
                 Console.WriteLine("===========================================================================================================================================");
                 //========================================================================================================
                 //*consider feranhigth tempratrur is 102 degree now convert into celcious 
                 int feranh = 102;
                 double celcious = ((feranh -32)*5/9);
                 Console.WriteLine("(10).temprature in feranhight = " + feranh + " \n" + "temprature Converted in celcious =" + celcious);
                 Console.ReadKey();
                 Console.WriteLine("==============================================================================================================================================");
                 //====================================================================================================================
                 //*Mr.Venkat Deposite 500000 amount in bank for 5 years with rate of interest  as 7.8%  After 5 years how much amount he will 
                 // recive .note=(Calculate intrest amount and total amount using simple intrest formula.
                 double damot = 500000;
                 int years = 5;
                 double intrate = 7.8;
                 double intamount = damot * years * intrate / 100;
                 double totalampt = damot + intamount;
                 Console.WriteLine("(11). Total amount is :=" + totalampt);
                 Console.WriteLine("----------- intraste amount is :=" + intamount);
                 Console.ReadKey();
              Console.WriteLine("============================================================================================================================================");
                 //============================================================================================================================ 
                 //* Swapping := Interchanging values is called swapping 
                 //* Write a Program to perform swapping of 2 numbers using 3rd variable.
                 int x = 3;
                 int y = 7;
                 int p = 9;
                 int q = 8;
                 int r;
                 Console.WriteLine("(12).Swapping value is :" + x + " " + y);
                 Console.WriteLine("Swapping value is :" + p + " " + q);
                  x =x+y  ;
                   y = x-y;
                  x = x-y;
                  r = p;
                  p = q;
                  p = r;
                 // tuple in C# swapping third method  .
                 //(p,q) = (q,p);
                 (x, y) = (y, x);
                 Console.WriteLine("Swapping value is :" + p + " " + q);
                 Console.WriteLine("after swaping value =" + x + " " + y);
                 Console.ReadKey();
                 Console.WriteLine("==========================================================================================================================================");
                 //=====================================================================================================================================
                 //* Miss pooja mansi started her journey from Hyderabad to vijaywada by car while started her journey she noticed that car reading as 11236 
                 // after reached vijaywada againe she noticed thad car reading shows as 11494 now w.a.p to find a number of kilometers she traveled.

                 int inti = 11236;
                 int rrach = 11494;
                 int kilo = rrach - inti;
                 Console.WriteLine("(15).total kilometer she traveled := " + kilo);

                 Console.ReadKey();
                 Console.WriteLine("===========================================================================================================================================");
                 //==========================================================================================================================================
                 //* mr venkat ready and his friends (vishnu and avinash ) went to restuarent and placed order as 3 plates manchurian and 2 plate biryani 
                 // we gave tip as 20 rs now they deside shear amount equality w.a.p to display there shearing amount (NOTE :- manchurian cost 220;
                 // biryani cost 360 per plate 
                 Console.WriteLine("==============================================================================================================================================");
                 int order1 = 3;
                 int order2 = 2;
                 double biruanicost = 360;
                 double manchue = 220;
                 double tipe = 20;
                 double mcot = order1 * manchue;
                 double bcost = order2 * biruanicost;
                 double totbill = mcot + bcost + tipe;
                 double divide = totbill / 3;
                 Console.WriteLine("(16).Manchurian cost = " + mcot + " \n" + "----biryani cost = " + bcost+"\n"+"----Tip amount="+tipe);
                 Console.WriteLine("----total bill with tip = " + totbill);
                 Console.WriteLine("-------per person bill amount is ="+ divide);
                 Console.ReadKey();
                 Console.WriteLine("==============================================================================================================================================");

                 //==================================================================================================================================
                 //*miss laxmi actual march milk bill is 930.0 but on that month milk boy kept 4 leaves , so write a program to calculate her march month milk bill.
                 int march = 31;
                 int leave = 4;
                 double milkb = 930.0;
                 double prdm = milkb / march;
                 double lebil = prdm * leave;
                 double finalb = milkb - lebil;
                 Console.WriteLine("(17).");
                 Console.WriteLine("MONTHLY BILL AMOUNT IS :" + milkb);
                 Console.WriteLine("MONTH OF THE BILL : MARCH \n ----- Days IN MONTH :"+march);
                 Console.WriteLine("TOTAL LEAVES MILK BOY TAKEN :" + leave);
                 Console.WriteLine("perday bill amount :"+prdm);
                 Console.WriteLine("total leave bill amouont :"+lebil);
                 Console.WriteLine(" total bill You want to Give  : "+ finalb);
                 Console.ReadKey();
                 Console.WriteLine("==============================================================================================================================================");

                 //==================================================================================================================================
                 //* miss pooja mansi attend 94 days out of 126 days.w.a.p to calculate percentage.
                 Console.WriteLine("(18).");
                 int today = 126;
                 int atenday = 94;
                 double perday = (atenday*100)/today;
                 Console.WriteLine("double perday = (atenday*100)/today -:- \n percentage :=" + perday);
                 Console.ReadKey();
                 Console.WriteLine("==============================================================================================================================================");

                 //==================================================================================================================================
                 //* in Apartment they needed  6 water can per day . W.A.P to calculate august month bill. each can 
                 // cost is 20.
                 Console.WriteLine("(19).");
                 int august = 31;
                 int perdaecan = 6;
                 double cscan = 20;
                 double costperday = perdaecan * cscan;
                 double augusmobill = costperday * august;
                 Console.WriteLine("--PER DAY CAN --:"+perdaecan);
                 Console.WriteLine(" --WATER CAN PRICE --: "+cscan);
                 Console.WriteLine("--PER DAY BILL --:"+costperday);
                 Console.WriteLine("--AUGUST MONTH BILL --:"+augusmobill);
                 Console.ReadKey();
                 Console.WriteLine("==============================================================================================================================================");

                 //===================================================================================================
                 //* One liter petrol cost is 108.96,now how manye litters petrol comes in 300rs
                 Console.Write("(20).");
                 double petro = 108.96;
                 int rup = 300;
                 double com =  rup / petro ;
                 Console.WriteLine("PETROL COST IS --: "+ petro);
                 Console.WriteLine("RUPEES YOU HAVE --:" + rup);
                 Console.WriteLine("YOU GETING PETROL --:" + com + "ltr");
                 Console.ReadKey();
                 Console.WriteLine("==============================================================================================================================================");

                 //==================================================================================================================
                 //* mr sharma bought mango basket for 1150, then he sold 1680, calculate his profit.
                 Console.Write("(21).");
                 int mango = 1150;
                 double sold = 1680;
                 double profit = mango - sold;
                 Console.WriteLine("BUYING PRICE IS ---:" + mango);
                 Console.WriteLine("SELLING PRICE IS ---:" + sold);
                 Console.WriteLine("SHARMA GOT PROFIT IS --:" + profit);
                 Console.ReadKey();
                 Console.WriteLine("==============================================================================================================================================");

                 //==================================================================================================================
                 //* Consider Product cost is 200,Get is 20% . now Find Gst amount and final cost of the product 
                 Console.WriteLine("(22).");
                 double pcosti = 200;
                 int gsat = 20;
                 double gstm = pcosti * gsat / 100;
                 double fi = gstm + pcosti;
                 Console.WriteLine("GST AMOUNT IS --:" + gstm);
                 Console.WriteLine("FINAL PRODUCT COST IS --:" + fi);
                 Console.ReadKey();
                 Console.WriteLine("==============================================================================================================================================");

                 //==================================================================================================================
                 //*Consider Pizza Cost is 326.50,Coustomer Order For 3 Pizzas,
                 //Now Calculate bill Aomount Shop Provides 20% Discount on bill amount.So find discount amt.
                 Console.WriteLine("(23).");
                 double picost = 326.50;
                 int orp = 3;
                 double bilamt = picost * orp;
                 int dis = 20;
                 double disamt = (dis *  bilamt) / 100;
                 double fbiant = bilamt - disamt;
                 Console.WriteLine("Pizaa Cost --= "+picost);
                 Console.WriteLine("Pizza ORder --= " + orp);
                 Console.WriteLine("Pizza Bill Amount --=" + bilamt);
                 Console.WriteLine("Discount Amount --=" + dis);
                 Console.WriteLine("Final Payble Amout --=" + fbiant);
                 Console.ReadKey();    
                 Console.WriteLine("==============================================================================================================================================");

                 //==================================================================================================================
                 //* consider employee monthly salary  30000,company reduce 12% aspfand 8% as tax then fianl monthly salary.
                 Console.WriteLine("(24).");
                 double montsal = 30000;
                 int asp = 12;
                 int tax = 8;
                 double redu = (montsal*asp)/ 100;
                 double andu = (montsal * tax) / 100;
                 double fnamont = andu + redu;
                 double fnnf = montsal - fnamont;

                 Console.WriteLine("ASP FUND AMOUNT := "+redu);
                 Console.WriteLine("TAX AMOUNT :=" +andu);
                 Console.WriteLine("TOTAL TAX AMOUNT :=" +fnamont);
                 Console.WriteLine("FINAL IN HAND SALARY AMOUNT :="+fnnf);
                 Console.ReadKey();
                 Console.WriteLine("==============================================================================================================================================");

                 //==================================================================================================================
                 //* MR.Venkat took 500000 loan Amount from bank For 4 years With rate of intrast 11.4% Now
                 //Calculate intrast Amount and Final Amount and EMI.
                 Console.WriteLine("(25).");
                 double bankamt = 50000;
                 int timpe = 4;
                 Double rrateo = 5 ;
                 int timmont = timpe * 12;
                 double rateofin = bankamt * timpe * rrateo / 110;
                 double totalamt = bankamt + rateofin;
                 double EMIACount = totalamt / timmont;
                 Console.WriteLine("DEPOSITE AMOUNT -:"+bankamt);
                 Console.WriteLine("INTRAST AMOUNT -:"+rateofin);
                 Console.WriteLine("TOTAL AMOUNT -:" +totalamt);
                 Console.WriteLine("CONVERTED IN EMI -:"+EMIACount);
                 Console.ReadKey();
                 Console.WriteLine("==============================================================================================================================================");

                 //==================================================================================================================
                 //* W.A.P To Find Electricity Bill Last Mont Reading is 2234,Currunt Month Reading is 2456. Now 
                 // Find number of units Consumed then Calculate bill amount. Per Unit 3.46,Taxs 0.06 per Unit and service charge is 30 
                 Console.WriteLine("(26).");
                 int laselbi = 2234;
                 int thismonelbil = 2456;
                 double perunit = 3.46;
                 double taam = 0.06;
                 double secha = 30;

                 int numunit = laselbi - thismonelbil;
                 double taxim = taam + perunit;
                 double billamt = numunit*taxim;
                 double servicechargadd = billamt + secha;
                 Console.WriteLine("CONSUMED UNIT -:" + numunit);
                 Console.WriteLine("FINAL ELCTRICITY BILL AMOUNT -:"+ servicechargadd);
                 Console.ReadKey();
                 Console.WriteLine("==============================================================================================================================================");


                 //==================================================================================================================
                 //* miss pooja mansi rent a car to go Vijaywada then started her journey from hyderabad to vijaywada by car 
                 // while starting her journey she noticed that her car reading 1123,after reached vijaywada again she noticed that her car
                 // reading as 11494 now calculate her car kilometere traveled.NOTE - per km they charged 15 rs,and total toll gate charged 200rs
                 Console.WriteLine("(27)."); 
                 int inn = 11236;
                 int en = 11494;
                 int totl = en -inn;
                 double chaarg = 15;
                 double chhh = totl * chaarg;
                 double tool = 200;
                 double finbilamt = chhh + tool;

                 Console.WriteLine("NUMBER OF KILOMETER SHE TRAVELED :: " + totl);
                 Console.WriteLine("BILL AMOUNT IS WITHOUT TOLL GATE CHARGE ::" + chhh);
                 Console.WriteLine("FINAL BILL AMOUNT INCLUEDE TOLL GATE CHARGE :: " +finbilamt);
                 Console.ReadKey();
                 Console.WriteLine("==============================================================================================================================================");

               //==================================================================================================================
               //* Write A Program To Read EMP Id,EMP NAme, Gender And SALARY Then Display All Details With Annual Salary.
               Console.WriteLine("(28).");
               Console.WriteLine(":::HI WELCOME ENTER YOUR DETAILS BELOW :::");
               Console.WriteLine("ENTER YOUR NAME -- ");
               String mmm = Console.ReadLine();
               Console.WriteLine("ENTER YOUR EMPLOYEE Id--");
               Byte ii = Convert.ToByte(Console.ReadLine());
               Console.WriteLine("ENTER YOUR GENDER BELOW ONLY FIRST CHAR OF GENDER --");
               Char gg = Convert.ToChar(Console.ReadLine());
               Console.WriteLine("ENTER YOUR MONTHLY SALARY --");
               Double sms = Convert.ToDouble(Console.ReadLine());
               double ansm = sms * 12;

               Console.WriteLine("***** HERE YOUR FULL DETAILS *****");
               Console.WriteLine("EMPLOYEE NAME = "+mmm);
               Console.WriteLine("EMPLOYEE ID ="+ii);
               Console.WriteLine("EMPLOYEE GENDER ="+gg);
               Console.WriteLine("EMPLOYEE MONTHLYEE SALARY ="+sms);
               Console.WriteLine("EMPLOYEE ANNUAL SALARY IS =" + ansm);
               Console.ReadKey();
               Console.WriteLine("==============================================================================================================================================");
               //==================================================================================================================
               //*Consider Biryani Cost is 395.25, Read quantity from user then Find Total bill.
               Console.WriteLine("(29).");
               double bircose = 395.25;
               Console.WriteLine("ONE BIRYANI COST IS ::"+bircose);
               Console.WriteLine("ENTER BIRYANI QUANTITY ::");
               int bco = Convert.ToInt32(Console.ReadLine());
               double bdd = bco * bircose;
               Console.WriteLine("BIRYANI BILL AMOUNT IS:-: " + bdd);
               Console.ReadKey();
               Console.WriteLine("==============================================================================================================================================");

               //==================================================================================================================
               //* Read amount from user then display in dollors 
               Console.WriteLine("(30).");
               Console.WriteLine("ENTER AMOUNT IN INR ::");
               double inma = Convert.ToDouble(Console.ReadLine());
               double usd = 84.09;
               double coami = inma/ usd;
               Console.WriteLine("ACTUAL INDIAN RUPEES ::"+inma);
               Console.WriteLine("INR CONVERTED IN DOLLER:: " + coami);
               Console.ReadKey();
               Console.WriteLine("==============================================================================================================================================");

               //==================================================================================================================
               //* Read Dollers From user Then Converd in INR Rupees 
               Console.WriteLine("(31)");
               Console.WriteLine("ENTER DOLLER'S::");
               double dolll = Convert.ToDouble(Console.ReadLine());
               double inff = 84.09;
               double convv = inff * dolll;
               Console.WriteLine("ACTUAL ENTERD DOLLER'S::"+dolll);
               Console.WriteLine("CONVERTED IN INDIAN RUPEES ::"+convv);
               Console.ReadKey();
               Console.WriteLine("==============================================================================================================================================");

               //==================================================================================================================
               //* from hyderabad to vijaywada genral cost ticket is rs 460 , Due to festival session the ticket cost increased as 50% 
               // (actual cost + 50% hike ) , now read number of ticket and find ticekt1 bill amount.  

               double tcco = 460;
               int fest = 50;
               double perod = tcco * fest / 100;
               double incrd = perod;
               double fbcos = tcco + incrd;
               Console.WriteLine("ENTER HOW MANY TICKET YOU WANT::");
               int tickek = Convert.ToInt32(Console.ReadLine());
               double nomcost = tcco * tickek;
               double finalss = fbcos * tickek;
               Console.WriteLine("SINGLE TICKET  COST IS ::"+tcco);
               Console.WriteLine("NORMAL COST IS ::" + nomcost);
               Console.WriteLine("TICKET COST INCRESED BY ::"+fest+"%");
               Console.WriteLine("INCRED COST AMOUNT ::" +incrd);
               Console.WriteLine("FINAL TICKET COST AMOUNT ::"+finalss );
               Console.ReadLine();
               Console.WriteLine("==============================================================================================================================================");
      
            //==================================================================================================================
            //*Read Employee annual salary and hike percentage then calculate annual salary after hike  and display monthly salary 
            Console.WriteLine("ENTER EMPLOYEE SALARY ::");
            double emsalll = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ENTER HIKE PERCENTAGE %::");
            int kkkk = Convert.ToInt32(Console.ReadLine());
            double hikw = emsalll * kkkk / 100;
            double hikll = emsalll + hikw;
            double mothsa = hikll / 12;
            Console.WriteLine("SALARY HIKE AMOUNT ::" + hikw);
            Console.WriteLine("SALARY HIKE AMOUNT ANNUALY ::"+hikll);
            Console.WriteLine("EMPLOYEE MONTHLY SALARY IS ::"+mothsa);
            Console.ReadKey();
            Console.WriteLine("==============================================================================================================================================");
            
            //==================================================================================================================
            //* Read Market value of a land , in genral stamp duety is 5% But Due to new rulea It charges as 7% So How Much Extra Amount They have to
            //Pay According to new rule . Calculate old Stamp Duety Amount and new stamp duty amount then display diffrence.

            Console.WriteLine("ENTER MARKET VALUE OF LAND ::");
            double readmount = Convert.ToDouble(Console.ReadLine());
            int gstam = 5;
            int newaar = 7;
            double olam = readmount * gstam / 100;
            double neao = readmount * newaar / 100;
            double olms = readmount + olam;
            double nolms = readmount + neao;
            Console.WriteLine("MRKET VALUE YOU ENTERD ::"+readmount);
            Console.WriteLine("OLD STAMP PERCENTAGE ::"+gstam+"%");
            Console.WriteLine("NER STAMP PERCENTAGE ::"+newaar+"%");
            Console.WriteLine("OLD STAMP DUTY AMOUNT ::  "+olms);
            Console.WriteLine("NEW RULE STAMP AMOUNT ::"+neao);
            Console.WriteLine("OLD STAMP INCLUED LAND VALUE ::"+olam);
            Console.WriteLine("NEW STAMP INCLUED LAND VALUE ::"+nolms);
            Console.ReadKey();
            Console.WriteLine("==============================================================================================================================================");
         
            //==================================================================================================================
            //*Read Temprature In Celcious And Convert in faranhght 
            Console.WriteLine("ENTER TEMPRATURE IN CELCIUOS ");
            int tece = Convert.ToInt32(Console.ReadLine());
           double feraght = ((tece * 9) / 5) + 32;
            Console.WriteLine("CONVERTED IN FARANHIGHT ::"+feraght);
            Console.ReadKey();
           
            //==================================================================================================================
            //*Read Temprature In faranhght then Convert in celcious 
            Console.WriteLine("ENTER TEMPRATURE IN FARANHIGHT :: ");
            double teph  = Convert.ToDouble(Console.ReadLine());
            double fecer = ((teph - 32) * 5 / 9);
            Console.WriteLine("CONVERTED IN FARANHIGHT ::" + fecer);
            Console.ReadKey();

            
            //==================================================================================================================
            //*read mano cost per kg , then read quantity.big basket gives offer as 22% discount on bill Amouonout .so find total bill amount 
            Console.WriteLine("ENTER MANGO COST BELOW ::");
            double Mgo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("===================================");
            Console.WriteLine("ENTER MANGO QUANTITY IN KG ::");
            double kgq = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("===================================");
            double bimg = Mgo * kgq;
            double dimo = bimg * 22 / 100;
            double ddis = bimg - dimo;
            Console.WriteLine("===================================");
            Console.WriteLine("MANGO COST IS :: " + Mgo);
            Console.WriteLine("MANGO QUANTITY IS ::"+kgq);
            Console.WriteLine("BILL AMOUNT WITHOUT DISCOUONT ::" +bimg);
            Console.WriteLine("YOU GET THE DISCOUNT AMOUNT IS ::" + dimo);
            Console.WriteLine("YOUR PAYBLE AMOUNT IS ::" +ddis);

            Console.WriteLine("===================================");
            Console.ReadKey();
            
           
            //==================================================================================================================
            //* mr venkat reddy Booked flight ticket in indian Air Lines to Travled Hyderabad to vijaywada
            //Genral ticket cost is 3450 and extra gst as 18% but if he book ticket in indigo ticket cost is 3200 
            // and extra gst as 12% so how much amount he saved if he book ticket indi go 


            double genco = 3450;
            double idigo = 3200;
            int indi = 18;
            int inso = 12;
            double airgst = (genco*indi) / 100;
            double gos = (idigo * inso) / 100;
            double fininidan = genco + airgst;
            double finaindigo = idigo + gos;
            double svedam = fininidan - finaindigo;
            Console.WriteLine("INIDAN AIRLINES AMOUONT :"+genco);
            Console.WriteLine("INDIGO AMOUNT :"+idigo);
            Console.WriteLine("INDIAN AIRLINES GST "+indi+"%");
            Console.WriteLine("INDIGO GST "+inso+"%");
            Console.WriteLine("INDIAN AIRLINE GST AMOUNT:"+airgst);
            Console.WriteLine("INDI GO GST AMOUNT :"+gos);
            Console.WriteLine("INDIAN AIRLINES AMOUNT WITH GST :"+fininidan);
            Console.WriteLine("INDI GO AMOUNT WITH GST :"+finaindigo);
            Console.WriteLine("THE DIFFRENCEBLE AMOUNT IS :"+svedam);
            Console.ReadKey();
             
            
            //==================================================================================================================
            //* REad Kilometers then Convet in meters
            Console.WriteLine("ENTER KILOMETER :");
            int kilmeter =Convert.ToInt32(Console.ReadLine());
            int metr = kilmeter * 1000;
            Console.WriteLine("YOU KILOMRTR:" + kilmeter);
            Console.WriteLine("KILOMETER IN METER:"+metr);
            Console.ReadKey();
          
            //==================================================================================================================
            //*Read Hourse then convert in days
            Console.WriteLine("ENTER Hours :");
           double hour = Convert.ToDouble(Console.ReadLine());
            double dday = hour/24 ;
            Console.WriteLine("HOURS iN DAYS ::"+ dday);
            Console.ReadKey();
        }
    }

    
}
