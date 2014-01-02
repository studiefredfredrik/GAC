GAC
----------------------------------------
Gulset Action Center gives mediacenter and lighting control on a web interface. 

GAC was designed to turn an old laptop into a mediaserver that could also
be used to control the light indoors. It also had to be able to support input 
from a number of devices around the house (android, iphone, linux laptops and
windows desktop). 

The solution was to create a .aspx web-site with snippets of C# that was hosted 
on an Abyss webserver running on an old laptop connected to the TV. An Arduino
board was connected via USB to provide easy IO to a couple of relays that turns
lights in the living room on/off.

Mediacenter capabilities was done with simple keystroke emulation in C# wich
controls a VLC mediaplayer session. 

Media files were transferred via SMB to a shared folder on the server. Media
files get litsted on the web interface and pressing play on the web interface
makes the movie play on the TV with VLC.

I can recomend Aprelium - Abyss Web Server (Ver. X1 is free)
The project also requires VLC mediaplayer to be installed.

