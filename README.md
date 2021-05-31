# Argon2 Web Config

This library is a modification of the Twelve21.PasswordStorage that helps you config the Argon2 hashing algorithm. I have modified the original so that I can run it on a web server. I do not take claim to creating the Agron2 config tool.

Original Source: https://github.com/bburman/Twelve21.PasswordStorage

How to use:

List<ArgonResult> results = new ConfigRunner().GetResults();
  
The above code will return a list of argon results. Each result repesents a way to config the Argon hashing algorithm to take about a second when hashing on certain hardware. 

Get Results can take in the following parameters:
  
  long maxTime = 1000
  
  int minIterations = 2
  
  Argon2Mode mode = Argon2Mode.Argon2i
  
  int saltAndPassLength = 16
  
  int hashLength = 16
  
  int maxMemoryMB = 64
  
