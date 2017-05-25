# RWSourceControlManager
Tool to help submit railworks routes to source control using windows junctions

## What is this for?

When making Content for Railworks your content is often spread across multiple folders, this tool collects them into one folder to make editing easier.

## How does it work?

The tool moves all your files to another place on you file system, it then creates Windows Junctions which make Railworks think the files are where they were before even though they were moved

## How do I install an existing project with this?

1. Clone the project repositiory as normal via Soruce Control, ensure the directory you clone to is your RWSourceControl directory (usually **C:\RWSourceControl** - the fileapth will look somthing like **C:\RWSourceControl\My_Awesome_Route**)
2. Load up RWSourceControl, and select the route you downloaded from the menu on the left
3. Once selected use the 'Quick Actions' menu to Link all folders, if this button is greyed out it means all folders are already linked

## I have a route I want to use for this

1. Backup your route, the system doesn't do this for you (*yet*) and I accept no responsibility for any lost work. You should be doing this already
2. Load RWSourceControlManager and navigate to File > Import from Disk
3. Add each folder you want to use with RWSourceControl manager using the dialogue sections for Routes, Source, Scenarios etc.
(The folder you select should be the top level folder of your work, for a route this is the folder with the really long name in **Content\Routes**)
4. Click Import - your files will be copied and a Junction replace them. Load Railworks and you should see no difference