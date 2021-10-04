# TMPS_Lab1

## Author: `Nichiforov Maxim`
## Topic: `Animal Shelter`

## Introduction:
    In this laboratory work I decided to create an animal shelter.
    Clients gonna choose the animals by the type and the age of the animal.
    Is it an old hamster? Or a newborn cat? Only client will decide.

## Implementation/Explanation:
    To start the project, you gonna need any environment that supports C#.
    No libs nor dependencies where added to the project so simple Visual Studio
    will do.

    For this laboratory work I've decided to use 3 design patterns:
    1) Factory. We will have newborn animals, young animals and old animals.
       Then they also will be divided into cats, dogs and hamsters.

    2) Builder. We will use it to "choose" (create) an animal.
       The idea here is to differentiate animals by their age. Depending of the age
       the price of the animal will be different.

       Director class will take care of organization.

    3) Singleton. We want our factories to exist in single exemplar.

    For client to finally choose the animal he needs to:
        1) Create the factory (which age do you want?)
        2) Choose the animal type            

## Conclusion
    The idea behind patterns I've used became a bit clearer for me after I've
    used them in practice. I can admit that some of them are very important for
    some situations. The main issue for me in this work was to get in pace with
    all the abstractions I've had to maintain, sometimes it was getting a bit
    tricky.
