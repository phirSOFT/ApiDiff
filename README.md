# ApiDiff
A tool to perform diff operations on the public members of an assembly.

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

