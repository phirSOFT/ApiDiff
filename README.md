# ApiDiff
The goal of this project is to provide a language agnostic tool to detect changes in the public api and determine wheter this changes are breaking or not. The tool shoul be used to determine the correct semantic version of an api.

## Assembly diff
An assembly can contain four kind of types, which define the publi API of that assembly.
* classes
* structs
* interfaces
* enums.

On theese entities the following operations can be performed.

1. Addition
> A new type is added to the assembly. This operation ist not breaking.

2. Move
> A type is renamed or moved to a different namespace. This operation is breaking.

3. Deletion
> A type is removed from the assembly. This operation is breaking.

4. Inner change
> The members of a type changed. This operation can be breaking.

