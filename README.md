# Acme.StringCalculator
Sample project for teaching/learning TDD to 1-n people, using Visual Studio and SpecFlow
Based on Roy Osheroves excellent TDD Kata (http://osherove.com/tdd-kata-1/)

## How to use it:
* The code is divided into 3 projects -- "production" code, developer test code and acceptance test code
* In its initial state, the acceptance tests all fail, and a unit test fails
1. Assign a person to fix the failing unit test (but nothing else)
2. After fixing the failing test, encourage the person to refactor (but not add/alter any observable behavior) the code and/or tests
3. Ask the person to add a unit test, which adds some sort of value. The value could be expressed as relevance from a development point of view, or derived from one of the currently failing acceptance tests
4. Ensure the test fails
5. Goto 1
* If you reach a point where all tests are green, feel free to uncomment the next section of acceptance tests
