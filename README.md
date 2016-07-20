# About
GAC - Gulset Action Center

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

Media files are transferred via the upload page to a folder on the server. 
Media files get listed on the web interface and pressing play on the web 
interface makes the movie play on the TV with VLC.

The project also requires VLC mediaplayer to be installed.
As of version 1.5 PHP is also required for the upload functionality.

## Light switch
![Light switch](https://github.com/studiefredfredrik/GAC/blob/master/Artwork/images%20for%20the%20wiki/lights%20default.PNG?raw=true)

The Lightswitch is the default page and lets the user turn the lights on or off. The C# code sends commands thru the COM port to the Arduino that controls the relays

## Media control
The media control page lets the user start playback of media files on the server (the server should be connected to a TV). 
It uses C# code to open VLC mediaplayer on the server and emulates keyboard events to control the playback.
The page by default scans the folder `C:\LANRW` for files and displays them in a listbox. The user would use the upload page to upload media files to the server.

![Media control](https://github.com/studiefredfredrik/GAC/blob/master/Artwork/images%20for%20the%20wiki/media.PNG?raw=true)

## Upload files
GAC also lets the user upload files to the server. It's the latest addition to the project and currently only supports files up to `2GB`. But it's still a WIP.

![Upload files](https://github.com/studiefredfredrik/GAC/blob/master/Artwork/images%20for%20the%20wiki/upload.PNG?raw=true)