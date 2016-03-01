# C# console application developed in Visual Studio 2015 Community Edition using various design patterns

Requirement1 : Create an application that will list the sports and their facilities. The objective is that each sport should use a facility where the game can be played. There can be different sports like soccer, swimming and basketball. There are different facilitis like outdoor field, indoor pool and indoor stadium.

Implementation Requirement1 : We have sports objects - Soccer and Swimming derived from the sports base class. The Facility base class is subclassed into Field and IndoorPool facility classes. A class of type sport is initilized with the facility it will be using. Implementation of facility is decoupled from the sport class that is using the faility. Client can start the game without knowing the details of the facility the sport is using.

Requirement2 : Facility manager is responsible for preparing the facility before the game starts. Now depending on the sport, multiple facility managers may be involved in preparing the facility. Only one facilty manager can work at a time and will call next facility manager after completing his work.

Implementation Requirement2 : We have the base class FacilityManager. This class holds reference to the next faiclity manager. If the next faility manager is not required then it will be set to null. Each sport gets it's facility manager and will ask the facility manager to prepare facility before the game starts.
