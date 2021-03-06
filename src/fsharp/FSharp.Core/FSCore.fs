namespace Microsoft.FSharp.Core

open System.Reflection

module internal SR =
    type private C (_dummy:System.Object) = class end
    let mutable Culture = System.Globalization.CultureInfo.CurrentUICulture
    let ResourceManager = new System.Resources.ResourceManager("FSCore", C(null).GetType().Assembly)
    let GetString(name:System.String) : System.String = ResourceManager.GetString(name, Culture)
    let GetObject(name:System.String) : System.Object = ResourceManager.GetObject(name, Culture)

    /// <summary>The match cases were incomplete</summary>
    let matchCasesIncomplete = "matchCasesIncomplete"

    /// <summary>First class uses of address-of operators are not permitted.</summary>
    let addressOpNotFirstClass = "addressOpNotFirstClass"

    /// <summary>The arrays have different lengths.</summary>
    let arraysHadDifferentLengths = "arraysHadDifferentLengths"

    /// <summary>The input array was empty.</summary>
    let arrayWasEmpty = "arrayWasEmpty"

    /// <summary>Input string was not in a correct format.</summary>
    let badFormatString = "badFormatString"

    /// <summary>Expecting delegate type.</summary>
    let delegateExpected = "delegateExpected"

    /// <summary>Dynamic invocation of DivideByInt involving coercions is not supported.</summary>
    let dyInvDivByIntCoerce = "dyInvDivByIntCoerce"

    /// <summary>Dynamic invocation of op_Addition involving coercions is not supported.</summary>
    let dyInvOpAddCoerce = "dyInvOpAddCoerce"

    /// <summary>Dynamic invocation of op_Addition involving overloading is not supported.</summary>
    let dyInvOpAddOverload = "dyInvOpAddOverload"

    /// <summary>Dynamic invocation of op_Multiply involving coercions is not supported.</summary>
    let dyInvOpMultCoerce = "dyInvOpMultCoerce"

    /// <summary>Dynamic invocation of op_Multiply involving overloading is not supported.</summary>
    let dyInvOpMultOverload = "dyInvOpMultOverload"

    /// <summary>The end of a range cannot be NaN.</summary>
    let endCannotBeNaN = "endCannotBeNaN"

    /// <summary>Enumeration already finished.</summary>
    let enumerationAlreadyFinished = "enumerationAlreadyFinished"

    /// <summary>Enumeration has not started. Call MoveNext.</summary>
    let enumerationNotStarted = "enumerationNotStarted"

    /// <summary>Set contains no elements.</summary>
    let setContainsNoElements = "setContainsNoElements"

    /// <summary>Enumeration based on System.Int32 exceeded System.Int32.MaxValue.</summary>
    let enumerationPastIntMaxValue = "enumerationPastIntMaxValue"

    /// <summary>Failed to read enough bytes from the stream.</summary>
    let failedReadEnoughBytes = "failedReadEnoughBytes"

    /// <summary>Failure during generic comparison: the type '{0}' does not implement the System.IComparable interface. This error may be arise from the use of a function such as 'compare', 'max' or 'min' or a data structure such as 'Set' or 'Map' whose keys contain instances of this type.</summary>
    let genericCompareFail1 = "genericCompareFail1"

    /// <summary>The index was outside the range of elements in the list.</summary>
    let indexOutOfBounds = "indexOutOfBounds"

    /// <summary>The input list was empty.</summary>
    let inputListWasEmpty = "inputListWasEmpty"

    /// <summary>The input must be non-negative.</summary>
    let inputMustBeNonNegative = "inputMustBeNonNegative"

    /// <summary>The input must be positive.</summary>
    let inputMustBePositive = "inputMustBePositive"

    /// <summary>The input sequence was empty.</summary>
    let inputSequenceEmpty = "inputSequenceEmpty"

    /// <summary>This is not a valid tuple type for the F# reflection library.</summary>
    let invalidTupleTypes = "invalidTupleTypes"

    /// <summary>The item, key, or index was not found in the collection.</summary>
    let keyNotFound = "keyNotFound"

    /// <summary>The lists had different lengths.</summary>
    let listsHadDifferentLengths = "listsHadDifferentLengths"

    /// <summary>The MailboxProcessor has already been started.</summary>
    let mailboxProcessorAlreadyStarted = "mailboxProcessorAlreadyStarted"

    /// <summary>MailboxProcessor.PostAndAsyncReply timed out.</summary>
    let mailboxProcessorPostAndAsyncReplyTimedOut = "mailboxProcessorPostAndAsyncReplyTimedOut"

    /// <summary>MailboxProcessor.PostAndReply timed out.</summary>
    let mailboxProcessorPostAndReplyTimedOut = "mailboxProcessorPostAndReplyTimedOut"

    /// <summary>Mailbox.Receive timed out.</summary>
    let mailboxReceiveTimedOut = "mailboxReceiveTimedOut"

    /// <summary>Mailbox.Scan timed out.</summary>
    let mailboxScanTimedOut = "mailboxScanTimedOut"

    /// <summary>Map values cannot be mutated.</summary>
    let mapCannotBeMutated = "mapCannotBeMutated"

    /// <summary>The IAsyncResult object provided does not match this 'Cancel' operation.</summary>
    let mismatchIARCancel = "mismatchIARCancel"

    /// <summary>The IAsyncResult object provided does not match this 'End' operation.</summary>
    let mismatchIAREnd = "mismatchIAREnd"

    /// <summary>Negating the minimum value of a twos complement number is invalid.</summary>
    let noNegateMinValue = "noNegateMinValue"

    /// <summary>The initialization of an object or value resulted in an object or value being accessed recursively before it was fully initialized.</summary>
    let checkInit = "checkInit"

    /// <summary>The static initialization of a file or type resulted in static data being accessed recursively before it was fully initialized.</summary>
    let checkStaticInit = "checkStaticInit"

    /// <summary>Arrays with non-zero base cannot be created on this platform.</summary>
    let nonZeroBasedDisallowed = "nonZeroBasedDisallowed"

    /// <summary>Type '{0}' is not a function type.</summary>
    let notAFunctionType = "notAFunctionType"

    /// <summary>Type '{0}' is not the representation of an F# exception declaration.</summary>
    let notAnExceptionType = "notAnExceptionType"

    /// <summary>The function did not compute a permutation.</summary>
    let notAPermutation = "notAPermutation"

    /// <summary>Type '{0}' is not an F# record type.</summary>
    let notARecordType = "notARecordType"

    /// <summary>Type '{0}' is not a tuple type.</summary>
    let notATupleType = "notATupleType"

    /// <summary>Type '{0}' is not an F# union type.</summary>
    let notAUnionType = "notAUnionType"

    /// <summary>The two objects have different types and are not comparable.</summary>
    let notComparable = "notComparable"

    /// <summary>The input sequence has an insufficient number of elements.</summary>
    let notEnoughElements = "notEnoughElements"

    /// <summary>This object is for recursive equality calls and cannot be used for hashing.</summary>
    let notUsedForHashing = "notUsedForHashing"

    /// <summary>One of the elements in the array is null.</summary>
    let nullsNotAllowedInArray = "nullsNotAllowedInArray"

    /// <summary>The object is not an F# record value.</summary>
    let objIsNotARecord = "objIsNotARecord"

    /// <summary>The object is null and no type was given.  Either pass a non-null object or a non-null type parameter.</summary>
    let objIsNullAndNoType = "objIsNullAndNoType"

    /// <summary>The index is outside the legal range.</summary>
    let outOfRange = "outOfRange"

    /// <summary>The type '{0}' is the representation of an F# exception declaration but its representation is private. You must specify BindingFlags.NonPublic to access private type representations.</summary>
    let privateExceptionType = "privateExceptionType"

    /// <summary>The type '{0}' is an F# record type but its representation is private. You must specify BindingFlags.NonPublic to access private type representations.</summary>
    let privateRecordType = "privateRecordType"

    /// <summary>The type '{0}' is an F# union type but its representation is private. You must specify BindingFlags.NonPublic to access private type representations.</summary>
    let privateUnionType = "privateUnionType"

    /// <summary>Expected exactly one type argument.</summary>
    let QexpectedOneType = "QexpectedOneType"

    /// <summary>Expected exactly two type arguments.</summary>
    let QexpectedTwoTypes = "QexpectedTwoTypes"

    /// <summary>Not a valid F# union case index.</summary>
    let QinvalidCaseIndex = "QinvalidCaseIndex"

    /// <summary>Type '{0}' did not have an F# record field named '{1}'.</summary>
    let QmissingRecordField = "QmissingRecordField"

    /// <summary>Type '{0}' did not have an F# union case named '{1}'.</summary>
    let QmissingUnionCase = "QmissingUnionCase"

    /// <summary>Type mismatch when building '{0}': the type of the field was incorrect. Expected '{1}', but received type '{2}'.</summary>
    let QtmmBadFieldType = "QtmmBadFieldType"

    /// <summary>Type mismatch when building '{0}': body must return unit. Expected '{1}', but received type '{2}'.</summary>
    let QtmmBodyMustBeUnit = "QtmmBodyMustBeUnit"

    /// <summary>Type mismatch when building '{0}': condition expression must be of type bool. Expected '{1}', but received type '{2}'.</summary>
    let QtmmCondMustBeBool = "QtmmCondMustBeBool"

    /// <summary>Type mismatch when building '{0}': expected function type in function application or let binding. Expected '{1}', but received type '{2}'.</summary>
    let QtmmExpectedFunction = "QtmmExpectedFunction"

    /// <summary>Type mismatch when building '{0}': expression doesn't match the tuple type. Expected '{1}', but received type '{2}'.</summary>
    let QtmmExprNotMatchTuple = "QtmmExprNotMatchTuple"

    /// <summary>Type mismatch when building '{0}': types of expression does not match. Expected '{1}', but received type '{2}'.</summary>
    let QtmmExprTypeMismatch = "QtmmExprTypeMismatch"

    /// <summary>Type mismatch when building '{0}': function argument type doesn't match. Expected '{1}', but received type '{2}'.</summary>
    let QtmmFunctionArgTypeMismatch = "QtmmFunctionArgTypeMismatch"

    /// <summary>Type mismatch when building '{0}': guard must return boolean. Expected '{1}', but received type '{2}'.</summary>
    let QtmmGuardMustBeBool = "QtmmGuardMustBeBool"

    /// <summary>Type mismatch when building '{0}': incorrect argument type for an F# record. Expected '{1}', but received type '{2}'.</summary>
    let QtmmIncorrectArgForRecord = "QtmmIncorrectArgForRecord"

    /// <summary>Type mismatch when building '{0}': incorrect argument type for an F# union. Expected '{1}', but received type '{2}'.</summary>
    let QtmmIncorrectArgForUnion = "QtmmIncorrectArgForUnion"

    /// <summary>Type mismatch when building '{0}': initializer doesn't match array type. Expected '{1}', but received type '{2}'.</summary>
    let QtmmInitArray = "QtmmInitArray"

    /// <summary>Type mismatch when building '{0}': invalid parameter for a method or indexer property. Expected '{1}', but received type '{2}'.</summary>
    let QtmmInvalidParam = "QtmmInvalidParam"

    /// <summary>Type mismatch when building '{0}': body of the for loop must be lambda taking integer as an argument. Expected '{1}', but received type '{2}'.</summary>
    let QtmmLoopBodyMustBeLambdaTakingInteger = "QtmmLoopBodyMustBeLambdaTakingInteger"

    /// <summary>Type mismatch when building '{0}': lower and upper bounds must be integers. Expected '{1}', but received type '{2}'.</summary>
    let QtmmLowerUpperBoundMustBeInt = "QtmmLowerUpperBoundMustBeInt"

    /// <summary>Type mismatch when building '{0}': types of true and false branches differ. Expected '{1}', but received type '{2}'.</summary>
    let QtmmTrueAndFalseMustMatch = "QtmmTrueAndFalseMustMatch"

    /// <summary>Type mismatch when building '{0}': mismatched type of argument and tuple element. Expected '{1}', but received type '{2}'.</summary>
    let QtmmTuple = "QtmmTuple"

    /// <summary>Type mismatch when building '{0}': the variable type doesn't match the type of the right-hand-side of a let binding. Expected '{1}', but received type '{2}'.</summary>
    let QtmmVarTypeNotMatchRHS = "QtmmVarTypeNotMatchRHS"

    /// <summary>Unexpected quotation hole in expression.</summary>
    let QunexpectedHole = "QunexpectedHole"

    /// <summary>The parameter is not a recognized method name.</summary>
    let QunrecognizedMethodCall = "QunrecognizedMethodCall"

    /// <summary>Reset is not supported on this enumerator.</summary>
    let resetNotSupported = "resetNotSupported"

    /// <summary>The start of a range cannot be NaN.</summary>
    let startCannotBeNaN = "startCannotBeNaN"

    /// <summary>The step of a range cannot be NaN.</summary>
    let stepCannotBeNaN = "stepCannotBeNaN"

    /// <summary>The step of a range cannot be zero.</summary>
    let stepCannotBeZero = "stepCannotBeZero"

    /// <summary>The System.Threading.SynchronizationContext.Current of the calling thread is null.</summary>
    let syncContextNull = "syncContextNull"

    /// <summary>The tuple index '{1}' was out of range for tuple type '{0}'.</summary>
    let tupleIndexOutOfRange = "tupleIndexOutOfRange"

    /// <summary>Failed to bind constructor</summary>
    let QfailedToBindConstructor = "QfailedToBindConstructor"

    /// <summary>Failed to bind field '{0}'</summary>
    let QfailedToBindField = "QfailedToBindField"

    /// <summary>Failed to bind property '{0}'</summary>
    let QfailedToBindProperty = "QfailedToBindProperty"

    /// <summary>Failed to bind type '{0}' in assembly '{1}'</summary>
    let QfailedToBindTypeInAssembly = "QfailedToBindTypeInAssembly"

    /// <summary>Incompatible record length</summary>
    let QincompatibleRecordLength = "QincompatibleRecordLength"

    /// <summary>Incorrect instance type</summary>
    let QincorrectInstanceType = "QincorrectInstanceType"

    /// <summary>Incorrect number of arguments</summary>
    let QincorrectNumArgs = "QincorrectNumArgs"

    /// <summary>Incorrect type</summary>
    let QincorrectType = "QincorrectType"

    /// <summary>Invalid function type</summary>
    let QinvalidFuncType = "QinvalidFuncType"

    /// <summary>The member is non-static (instance), but no receiver object was supplied</summary>
    let QnonStaticNoReceiverObject = "QnonStaticNoReceiverObject"

    /// <summary>Parent type cannot be null</summary>
    let QparentCannotBeNull = "QparentCannotBeNull"

    /// <summary>Reading a set-only property</summary>
    let QreadingSetOnly = "QreadingSetOnly"

    /// <summary>Receiver object was unexpected, as member is static</summary>
    let QstaticWithReceiverObject = "QstaticWithReceiverObject"

    /// <summary>Type mismatch when building '{0}': the expression has the wrong type. Expected '{1}', but received type '{2}'.</summary>
    let QtmmExprHasWrongType = "QtmmExprHasWrongType"

    /// <summary>Type mismatch when building '{0}': function type doesn't match delegate type. Expected '{1}', but received type '{2}'.</summary>
    let QtmmFunTypeNotMatchDelegate = "QtmmFunTypeNotMatchDelegate"

    /// <summary>Type mismatch when splicing expression into quotation literal. The type of the expression tree being inserted doesn't match the type expected by the splicing operation. Expected '{0}', but received type '{1}'. Consider type-annotating with the expected expression type, e.g., (%% x : {0}) or (%x : {0}).</summary>
    let QtmmRaw = "QtmmRaw"

    /// <summary>Tuple access out of range</summary>
    let QtupleAccessOutOfRange = "QtupleAccessOutOfRange"

    /// <summary>The tuple lengths are different</summary>
    let QtupleLengthsDiffer = "QtupleLengthsDiffer"

    /// <summary>F# union type requires different number of arguments</summary>
    let QunionNeedsDiffNumArgs = "QunionNeedsDiffNumArgs"

    /// <summary>Writing a get-only property</summary>
    let QwritingGetOnly = "QwritingGetOnly"

    /// <summary>The method '{0}' expects {1} type arguments but {2} were provided</summary>
    let QwrongNumOfTypeArgs = "QwrongNumOfTypeArgs"

    /// <summary>An index satisfying the predicate was not found in the collection.</summary>
    let keyNotFoundAlt = "keyNotFoundAlt"

    /// <summary>The constructor method '{0}' for the union case could not be found</summary>
    let constructorForUnionCaseNotFound = "constructorForUnionCaseNotFound"

    /// <summary>first class uses of '%' or '%%' are not permitted</summary>
    let firstClassUsesOfSplice = "firstClassUsesOfSplice"

    /// <summary>MoveNext not called, or finished</summary>
    let moveNextNotCalledOrFinished = "moveNextNotCalledOrFinished"

    /// <summary>Multiple CompilationMappingAttributes, expected at most one</summary>
    let multipleCompilationMappings = "multipleCompilationMappings"

    /// <summary>Bad float value</summary>
    let printfBadFloatValue = "printfBadFloatValue"

    /// <summary>Bad format specifier:{0}</summary>
    let printfBadFormatSpecifier = "printfBadFormatSpecifier"

    /// <summary>Bad integer supplied to dynamic formatter</summary>
    let printfBadIntegerForDynamicFomatter = "printfBadIntegerForDynamicFomatter"

    /// <summary>Expected a precision argument</summary>
    let printfExpectedPrecision = "printfExpectedPrecision"

    /// <summary>Expected a width argument</summary>
    let printfExpectedWidth = "printfExpectedWidth"

    /// <summary>The # formatting modifier is invalid in F#</summary>
    let printfHashFormatSpecifierIllegal = "printfHashFormatSpecifierIllegal"

    /// <summary>Missing format specifier</summary>
    let printfMissingFormatSpecifier = "printfMissingFormatSpecifier"

    /// <summary>Not a function type</summary>
    let printfNotAFunType = "printfNotAFunType"

    /// <summary>Bad format specifier (precision)</summary>
    let printfPrecisonSpecifierIllegal = "printfPrecisonSpecifierIllegal"

    /// <summary>Bad format specifier (after {0})</summary>
    let printfSpecifierAfterIllegal = "printfSpecifierAfterIllegal"

    /// <summary>Bad format specifier (width)</summary>
    let printfWidthSpecifierIllegal = "printfWidthSpecifierIllegal"

    /// <summary>Could not bind function {0} in type {1}</summary>
    let QcannotBindFunction = "QcannotBindFunction"

    /// <summary>Could not bind property {0} in type {1}</summary>
    let QcannotBindProperty = "QcannotBindProperty"

    /// <summary>Could not bind to method</summary>
    let QcannotBindToMethod = "QcannotBindToMethod"

    /// <summary>Cannot take the address of this quotation</summary>
    let QcannotTakeAddress = "QcannotTakeAddress"

    /// <summary>Failed to bind assembly '{0}' while processing quotation data</summary>
    let QfailedToBindAssembly = "QfailedToBindAssembly"

    /// <summary>ill formed expression: AppOp or LetOp</summary>
    let QillFormedAppOrLet = "QillFormedAppOrLet"

    /// <summary>type argument out of range</summary>
    let QtypeArgumentOutOfRange = "QtypeArgumentOutOfRange"

    /// <summary>This value cannot be mutated</summary>
    let thisValueCannotBeMutated = "thisValueCannotBeMutated"

    /// <summary>The option value was None</summary>
    let optionValueWasNone = "optionValueWasNone"

    /// <summary>A continuation provided by Async.FromContinuations was invoked multiple times</summary>
    let controlContinuationInvokedMultipleTimes = "controlContinuationInvokedMultipleTimes"

    /// <summary>The record type '{0}' is invalid. Required constructor is not defined.</summary>
    let invalidRecordTypeConstructorNotDefined = "invalidRecordTypeConstructorNotDefined"

    /// <summary>The tuple type '{0}' is invalid. Required constructor is not defined.</summary>
    let invalidTupleTypeConstructorNotDefined = "invalidTupleTypeConstructorNotDefined"

    /// <summary>The input sequence contains more than one element.</summary>
    let inputSequenceTooLong = "inputSequenceTooLong"

    /// <summary>'thenBy' and 'thenByDescending' may only be used with an ordered input</summary>
    let thenByError = "thenByError"

    /// <summary>Unrecognized use of a 'sumBy' or 'averageBy' operator in a query. In queries whose original data is of static type IQueryable, these operators may only be used with result type int32, int64, single, double or decimal</summary>
    let failDueToUnsupportedInputTypeInSumByOrAverageBy = "failDueToUnsupportedInputTypeInSumByOrAverageBy"

    /// <summary>An if/then/else conditional or pattern matching expression with multiple branches is not permitted in a query. An if/then/else conditional may be used.</summary>
    let unsupportedIfThenElse = "unsupportedIfThenElse"

    /// <summary>This is not a valid query expression. The following construct was used in a query but is not recognized by the F#-to-LINQ query translator:\n{0}\nCheck the specification of permitted queries and consider moving some of the operations out of the query expression.</summary>
    let unsupportedQueryConstruct = "unsupportedQueryConstruct"

    /// <summary>This is not a valid query expression. The method '{0}' was used in a query but is not recognized by the F#-to-LINQ query translator. Check the specification of permitted queries and consider moving some of the operations out of the query expression</summary>
    let unsupportedQueryCall = "unsupportedQueryCall"

    /// <summary>This is not a valid query expression. The property '{0}' was used in a query but is not recognized by the F#-to-LINQ query translator. Check the specification of permitted queries and consider moving some of the operations out of the query expression.</summary>
    let unsupportedQueryProperty = "unsupportedQueryProperty"

    /// <summary>This is not a valid query expression. The construct '{0}' was used in a query but is not recognized by the F#-to-LINQ query translator. Check the specification of permitted queries and consider moving some of the operations out of the query expression.</summary>
    let unsupportedQueryConstructKind = "unsupportedQueryConstructKind"

    /// <summary>maxDegreeOfParallelism must be positive, was {0}</summary>
    let maxDegreeOfParallelismNotPositive = "maxDegreeOfParallelismNotPositive"
