# C# console application developed in Visual Studio 2015 Community Edition using bridge pattern

Requirement: Create an application that will list the sports and their facilities. The objective is that each sport should use a facility where the game can be played. There can be different sports like soccer, swimming and basketball. There are different facilitis like outdoor field, indoor pool and indoor stadium.

We have sports objects - Soccer and Swimming derived from the sports base class. The Facility base class is subclassed into Field and IndoorPool facility classes. A class of type sport is initilized with the facility it will be using. Implementation of facility is decoupled from the sport class that is using the faility. Client can start the game without knowing the details of the facility the sport is using.
