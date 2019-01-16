using System; 
  
class Geeks { 
  
    // Main Method 
    public static void Main() 
    { 
  
        // string type 
        String str = "GeeksforGeeks"; 
        String substr1 = "for"; 
        String substr2 = "For"; 
  
        // using String.Contains() Method 
        Console.WriteLine(str.Contains(substr1)); 
  
        // Here case-sensitive comparision 
        // And substr2 value is 'For' 
        // So its return false 
        Console.WriteLine(str.Contains(substr2)); 
    } 
} 