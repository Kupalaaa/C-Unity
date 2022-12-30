using Tasks_1;

namespace Tasks_1
{
     public class Menu 
     {
         Tasks task = new Tasks();
         public void ShowMenu()
         {
             Console.WriteLine("Select Task: ");
             var tasks = Int32.Parse(Console.ReadLine());
             switch (tasks)
             {
                 case 1:
                 {
                     task.Task_1();
                     break;
                 }
                 case 2:
                 {
                     task.Task_2();
                     break;
                 }
                 case 3:
                 {
                     task.Task_3();
                     break;
                 }
                 case 4:
                 {
                     task.Task_4();
                     break;
                 }
                 case 5:
                 {
                     task.Task_5();
                     break;
                 }
                 case 6:
                 {
                     task.Task_6();
                     break;
                 }
                 case 7:
                 {
                     task.Task_7();
                     break;
                 }
                 case 8:
                 {
                     task.Task_8();
                     break;
                 }
                 case 9:
                 {
                     task.Task_9();
                     break;
                 }
                 case 10:
                 {
                     task.Task_10();
                     break;
                 }
                 case 11:
                 {
                     task.Task_11();
                     break;
                 }
                 case 0:
                 {
                     Console.WriteLine("Thanks for using this shit program...");
                     break;
                 }
             }
         }

     }
}