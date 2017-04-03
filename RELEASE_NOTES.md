
#### 0.2.1-beta - March 23 2017
* Fix addresses deserialization

#### 0.2.0-beta - March 22 2017
* Using Salesforce API v30.0
* PR #23 FEAT: can use take and skip when selecting a member
* PR #21 FEAT: Paging, OrderBy multiple fields, OrElse in WhereArgs
* PR #20 FIX: QueryProvider CreateQuery (non-generic) not working

#### 0.1.5-beta - February 24 2017
* Implement SOQL Count().
* Fix: assign entity Id after insert operation.

#### 0.1.4-beta - February 23 2017
* Fix members select issues.
* Fix anonymous types select issues.

#### 0.1.3-beta - February 04 2017
* Improve serialization.
* Only send modified properties during insert and update operations.

#### 0.1.2-beta - January 31 2017
* Detect wrong references during code generation

#### 0.1.1-beta - January 31 2017
* Implements SingleOrDefault Single and FirstOrDefault like with other linq frameworks

#### 0.1.0-beta - January 31 2017
* Insert requests returns created id

#### 0.0.9-beta - January 27 2017
* Add types converters for pick list
* Calculated fields are readonly

#### 0.0.8-beta - January 04 2017
* Can specify table names using EntityNameAttribute on entities

#### 0.0.7-beta - January 02 2017
* Plurialize tables and fix a wording in generator arguments

#### 0.0.6-beta - December 13 2016
* Fix cases inserting

#### 0.0.5-beta - December 13 2016
* Fix casting int to double in where clause

#### 0.0.4-beta - December 13 2016
* Fix double serialization (was not in invariant culture)

#### 0.0.3-beta - December 12 2016
* Merge PR #8 fixing DateTimes requests
* Fix some types handling (double, int, long) in where clauses

#### 0.0.2-beta - November 26 2016
* First beta NuGet

#### 0.0.1-beta - November 23 2016
* Initial release

