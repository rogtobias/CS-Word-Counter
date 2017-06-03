# _Word Counter_

#### _It will count the number of times a word is repeated that the user has inputted, June 2, 2017_

#### By _**Roger Tobias**_

## Description

_This application will take in a word from a user and then a sentence. It will then display a results page indicating that they have entered a sentence, a word, and then will display the number of times that word was used._

## Setup/Installation Requirements

* _Go here: https://github.com/rogtobias?tab=repositories_
* _Select CS-Word-Counter_
* _Click the Clone or Download Button_
* _In Windows PowerShell, go to CS-Word-Counter root folder._
* _In CS-Word-Counter's root folder, input >dnx kestrel while in Powershell._

## Specs

* _If the user doesn't input both a word and a sentence to be checked, and doesn't click submit, nothing happens.(ex. input:(left blank) => output: nothing) - The reason why I chose this as the simplest is because nothing is nothingness._
* _If the user inputs a single word in the word to be checked field and a sentence without a matching single word, the output will be zero matching words.(ex. input:(single word):sun, input:(sentence):See Spot run.:submit => output: 0) - The reason why I chose this as the second simplest is because if it doesn't find any matches, the output will be what the counter was initialized with, zero._
* _If the user inputs a single word in the word to be checked field and a sentence containing the word, the output will count how many times that word is repeated in the sentence.(ex. input:(single word):day, input:(sentence):The day was sunny, but the day wasn't bright.:submit => output:2) - The reason why I chose this as the third simplest is because it will count the number of times the word is used._
* _If the user inputs a single word in the word to be checked field and/ or a sentence that has both upper and lower case letters. The app will still produce the correct output.(ex. input:(single word):LoNg, input:(sentence):ThE lOnG rOaD was Made Longer By THE LoNG dAY.:submit => output:2) - The reason why I chose this as the hardest is because the logic will have to do some converting to catch proper pronouns for example, if that is what's being searched for._


## Known Bugs

_There is a bug. Only the test words from the test file will be counted if the user happens to use one of those words. When the user puts in a word that's not in the tests, the counted words return 0 after going through the for loop and then if statement. Ironically the user word is being put into the proper variable and as well with the sentence. The sentence has been confirmed to be put into an array, but the CountRepeats function won't run on the user's inputted word, unless its one of the test words._

## Support and contact details

_Support at world@peace.com_

## Technologies Used

_C#, Nancy, Razor_

### License

*MIT licensing*

Copyright (c) 2016 **_Roger_**
