﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.SourceFiles
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class ExceptionClass : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"

	AddLicenseHeader();

            
            #line default
            #line hidden
            this.Write("using System;\r\nusing System.Net;\r\nusing Amazon.Runtime;\r\n\r\nnamespace ");
            
            #line 13 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model\r\n{\r\n    ///<summary>\r\n    /// ");
            
            #line 16 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write(" exception\r\n    /// </summary>\r\n    public class ");
            
            #line 18 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Exception.Name));
            
            #line default
            #line hidden
            this.Write(" : ");
            
            #line 18 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(BaseException));
            
            #line default
            #line hidden
            this.Write(" \r\n    {\r\n        /// <summary>\r\n        /// Constructs a new ");
            
            #line 21 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Exception.Name));
            
            #line default
            #line hidden
            this.Write(" with the specified error\r\n        /// message.\r\n        /// </summary>\r\n        " +
                    "/// <param name=\"message\">\r\n        /// Describes the error encountered.\r\n      " +
                    "  /// </param>\r\n        public ");
            
            #line 27 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Exception.Name));
            
            #line default
            #line hidden
            this.Write("(string message) \r\n            : base(message) {}\r\n          \r\n        /// <summa" +
                    "ry>\r\n        /// Construct instance of ");
            
            #line 31 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Exception.Name));
            
            #line default
            #line hidden
            this.Write("\r\n        /// </summary>\r\n        /// <param name=\"message\"></param>\r\n        ///" +
                    " <param name=\"innerException\"></param>\r\n        public ");
            
            #line 35 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Exception.Name));
            
            #line default
            #line hidden
            this.Write("(string message, Exception innerException) \r\n            : base(message, innerExc" +
                    "eption) {}\r\n            \r\n        /// <summary>\r\n        /// Construct instance " +
                    "of ");
            
            #line 39 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Exception.Name));
            
            #line default
            #line hidden
            this.Write("\r\n        /// </summary>\r\n        /// <param name=\"innerException\"></param>\r\n    " +
                    "    public ");
            
            #line 42 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Exception.Name));
            
            #line default
            #line hidden
            this.Write("(Exception innerException) \r\n            : base(innerException) {}\r\n            \r" +
                    "\n        /// <summary>\r\n        /// Construct instance of ");
            
            #line 46 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Exception.Name));
            
            #line default
            #line hidden
            this.Write(@"
        /// </summary>
        /// <param name=""message""></param>
        /// <param name=""innerException""></param>
        /// <param name=""errorType""></param>
        /// <param name=""errorCode""></param>
        /// <param name=""requestId""></param>
        /// <param name=""statusCode""></param>
        public ");
            
            #line 54 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Exception.Name));
            
            #line default
            #line hidden
            this.Write(@"(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of ");
            
            #line 58 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Exception.Name));
            
            #line default
            #line hidden
            this.Write(@"
        /// </summary>
        /// <param name=""message""></param>
        /// <param name=""errorType""></param>
        /// <param name=""errorCode""></param>
        /// <param name=""requestId""></param>
        /// <param name=""statusCode""></param>
        public ");
            
            #line 65 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Exception.Name));
            
            #line default
            #line hidden
            this.Write("(string message, ErrorType errorType, string errorCode, string requestId, HttpSta" +
                    "tusCode statusCode) \r\n            : base(message, errorType, errorCode, requestI" +
                    "d, statusCode) {}\r\n\r\n");
            
            #line 68 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
		
		if(this.GenerateComplexException)
		{
			foreach(var member in Exception.Structure.Members)
			{
				if(member.PropertyName.Equals("Message")) continue;

            
            #line default
            #line hidden
            this.Write("        /// <summary>\r\n        /// Gets and sets the ");
            
            #line 76 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write(" property.\r\n        /// </summary>\r\n\t\tpublic ");
            
            #line 78 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.DetermineType()));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 78 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write(" { get; set; }\r\n\r\n");
            
            #line 80 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"

			}
		}

            
            #line default
            #line hidden
            this.Write("    }\r\n}\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 87 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"

    public ExceptionModel Exception { get; set; }

	public bool GenerateComplexException { get; set; }

	public string BaseException { get; set; }

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
