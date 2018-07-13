using System;

namespace Ses03
{
	class MultipleInherit
	{

	}

	interface I1
	{

	}

	interface I2 
	{

	}

	interface I3 :  I2, I1
	{

	}

	class C1 :I1
	{

	}

	class C2 : C1,I1,I2,I3
	{
	}

}
