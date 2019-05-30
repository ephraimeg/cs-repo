# SongArchive
----
Desktop Management System for released songs, and albums by different artist and composers _(also a C# exercise)_ 

## User Interface


## Entities

##### Artists _(id, firstname, lastname)_
- an artist can sing or compose songs

##### Albums _(id, name)_
- an album can contain multiple songs
- an album can belong to multiple artists

##### Songs _(id, title)_
- a song is composed by one or many artist
- a song may be sung by one or many artist
- a song may or may not be in an album
- a song may belong to multiple albums

## Features

##### Main Form
```
[x] view song list
[x] view artist list
[x] view album list
[x] view singers
[x] view composers list
[ ] search all lists
[x] access to create entity view
[x] access to entity detail view
```
##### Entity Detail View
###### View
```
 [/] Artist
 [/] Song
 [ ] Album
 ```
###### Export to XML
```
 [x] Artist
 [x] Song
 [ ] Album
 ```
###### Update
```
 [ ] Artist
 [ ] Song
 [ ] Album
 ```
###### Delete
```
 [ ] Artist
 [ ] Song
 [ ] Album
 ```
##### Entity Creation View
###### Create
```
 [x] Artist
 [ ] Song
 [ ] Album
 ```