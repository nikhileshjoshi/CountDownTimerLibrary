# CountDownTimerLibrary

Its a simple countdown timer library. You can create multiple instances of the timer with very less overhead on the CPU.

Example: Countdown for 5 seconds.
```C#
  CountDownTimer timer = new CountDownTimer(new TimeSpan(0,0,0,5));
  timer.Start();
  //Do work for 3 seconds
  //Call timer.Remaining() to get the remaining time.
  Console.WriteLine(timer.Remaining()); //prints 00:00:02.00000
  //It can be called multiple times.
  //When the timer runs out, the time remaining is returned as a negative TimeSpan
  //the calling function will have to handle it accordingly.
  //Below code called after 10 seconds
  Console.WriteLine(timer.Remaining()); //prints -00:00:05.00000
```
  
