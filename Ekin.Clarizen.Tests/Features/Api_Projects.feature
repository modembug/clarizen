﻿Feature: Api_Projects
	Check I can do things with the projects


Scenario: CountProjects
Given I Login using credentials in appsettings
	Then there are '1' projects
Scenario: CreateProject
	Given I Login using credentials in appsettings
	And I create a project.  