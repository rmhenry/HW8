//Copyright (c) 2002, Art Gittleman
//This example is provided WITHOUT ANY WARRANTY 
//either expressed or implied.

/* Groups fields for a name.     
 * Uses ToString to display.
 */

using System;
public class Name {
  private String first;
  private char initial;
  private String last;
          
  public Name(String f, String l) {
    first = f; 
    last = l; 
  }
  public Name(String f, char i, String l) : this(f,l) {
    initial = i;  
  } 
  public override String ToString() {
    if (initial == '\u0000')
       return first + " " + last;
    else  
       return first + " " + initial + " " + last;
  }
}
