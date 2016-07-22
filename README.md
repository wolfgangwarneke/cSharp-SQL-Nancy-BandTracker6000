# Band Tracker 6000

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
| Adds show to database | Date: 7.18.2016, Band: "Eat Your Young" (obviously a 'grindcore' band), Venue: "The Mischievous Kitten" | Show is added to database. |
| Shows band details (name, genre, likes, and shows played) when band name is clicked | Select "" | Name: ""; Genre: ""; FB likes: 128; shows: "March 4th, 2013 at The Scratching Post", "Jan 2nd, 2013 at The Scratching Post" |
### Test Specifications
#### Band Tests
| Test        | Method | Input           | Output (or outcome)  |
| ------------- |:----:|:-------------:| -----:|
| Database is initially empty | GetAll() | n/a | Count of entries is 0. |
| Two identical entries are treated as one entry. | Equals() | First band: "The Paw-lice", second band: "The Paw-lice" | First band is same as second band. |
| Saves new band to database | Save() | New band object | Band is written as new row entry in database |
| Clears all bands from database | DeleteAll() | n/a | all entries for 'bands' database table are removed |
| Removes one band from database | DeleteThis() | any band object | row containing this band's information is removed from database |
| Returns band by band id | Find() | (database of bands contains: "The Paw-Lice" with id of 9 and "Here Kitty Kitty" with id of 4) Band.Find(9) | Band object for "Here Kitty Kitty" |
| Changes band name to a new inputted name | UpdateName() | (band is called "Siamese Dream", gets sued by Billy Corgan from the Smashing Pumpkins for copyright infringement) this.UpdateName("The Bengals") | Band name is changed to The Bengals |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |

#### Venue Tests
| Test        | Method | Input           | Output (or outcome)  |
| ------------- |:----:|:-------------:| -----:|
| Database is initially empty | GetAll() | n/a | Count of entries is 0. |
| Two indentical entries are treated as one entry | Equals() | First venue: "The Milky Way"; Second venue: "Cat Fancy Theater" | First venue is same as second venue. |
| Saves new venue to database | Save() | New venue object | Venue is written as new row entry in database |
| Clears all venues from database | DeleteAll() | n/a | all entries for 'venues' database table are removed |
| Removes one venue from database | DeleteThis() | any venue object | row containing this venue's information is removed from database|
| Returns venue by venue id | Find() | (Venues database tabke contains: "The Meow" with id of 2 and "The Yarn Ballroom" with id of 3) Venue.Find(2) | Venue object for "The Meow" |
| Changes venue name to a new inputted name | UpdateVenueName() | (venue is called "The Meow") this.UpdateVenueName("The Meow Meow") | Venue name is changed to "The Meow Meow" |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |
#### Show Tests
| Test        | Method | Input           | Output  |
| ------------- |:----:|:-------------:| -----:|
| Database is initially empty | GetAll() | n/a | Count of entries is 0. |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |
|  |  |  |  |

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
