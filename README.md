# Band Tracker

#### Keep track of venues the bands that play them, July 22nd, 2016_

#### By Wolfgang Warneke

## Description

This is a project for my C# class at Epicodus. Remember than one show? Me either, so let's check out our database of venues and bands to see if we can jog our collective memory. See all bands that have played a venue and when those shows were. See all venues that a band has played. Oh look now I remember, see, remember when Rumpleteaser played a sweet solo set at the Cat's Cradle on April, 20th, 2015? He was pretty sloppy due to his catnip problem around that time, but we still went out for saucers of milk afterword. Classy.

## Specifications
### General Specifications
| Behavior        | Input           | Outcome  |
| ------------- |:-------------:| -----:|
| Adds band to database | "The Neutered Tomcats" | "The Neutered Tomcats" is displayed in all bands list. |
| Adds genre parameter for bands | name: "The Neutered Tomcats", genre: "rockabilly" | "The Neutered Tomcats" is displayed in the all bands lists AND the rockabilly bands list. |
| Adds FB likes parameter for bands | name: "Rumpleteaser", genre: "folk", FB likes: 45,000; name: "The Neutered Tomcats", genre: "rockabilly", FB likes: 245 | "Rumpleteaser" is displayed before "The Neutered Tomcats" when viewing "by popularity" |
| Adds venue to database | "The Cat's Cradle" | "The Cat's Cradle" is displayed in all venues list |
| Adds signature genre parameter for venues | name: "The Cat's Cradle"; main genre: "folk" | "The Cat's Cradle" is suggested as a venue when viewing all punk bands" |
| Adds capacity parameter for venues | name: "The Yarn Ballroom", capacity: 500; name: "The Cat's Cradle", capacity: 120 | "The Yarn Ballroom" is displayed before "The Cat's Cradle" when viewing venues by size |
| Adds show to database | Date: 7.18.2016, Band: "Eat Your Young" (obviously a 'grindcore' band), Venue: "The Mischievous Kitten" | Show is added to database. Show is displayed when viewing details for either "Eat Your Young" or "The Mischievous Kitten" |
### Test Specifications
| Behavior        | Input           | Outcome  |
| ------------- |:-------------:| -----:|
|  |  |  |

## Setup/Installation Requirements

* Snap Your Fingers
* Do Your Stuff

_I'm going to tell you what to do. Don't worry._

## Known Bugs

_The only good bug is an nonexistent bug._

## Support and contact details

_Twitter: @wolfgangwarneke_

## Technologies Used

_This project uses C#, SQL, and the Nancy framework._

### License

Copyright (c) 2016 **Wolfgang Warneke**
