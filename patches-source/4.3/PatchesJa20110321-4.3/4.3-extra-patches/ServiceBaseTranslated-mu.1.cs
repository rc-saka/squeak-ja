'From Squeak4.1 of 17 April 2010 [latest update: #9957] on 25 April 2010 at 12:34:15 am'!"Change Set:		ServiceBaseTranslated-muDate:			19 January 2008Author:			Masashi UmezawaAdded #translated sendings to Services-Base package so that services-generated menu and button will be translated"!!BasicRequestor methodsFor: 'generic requests' stamp: 'mu 4/25/2010 00:34'!getString	| result |	result := UIManager default  request: caption translated initialAnswer:answer contents.	self newCaption.	result isEmpty  |result isNil  ifTrue:[ServiceCancelled signal].	^ result! !!ServiceAction methodsFor: 'accessing' stamp: 'mu 2/9/2008 14:45'!buttonLabel	^ (shortLabel		ifNil: [self text]		ifNotNil: [shortLabel ifEmpty: [self text] ifNotEmpty: [shortLabel]]) translated! !!ServiceAction methodsFor: 'accessing' stamp: 'mu 2/9/2008 14:45'!description	^ (description ifNil: [self text] ifNotNil: [description]) translated! !!ServiceAction methodsFor: 'accessing' stamp: 'mu 1/19/2008 19:33'!menuLabel	| l sh |	l := self text translated.	l size > 50 ifTrue: [l := (l first: 47), '...'].		sh := self shortcut.	sh := (sh isNil or: [sh isEmpty]) ifTrue: [''] ifFalse: [' (', sh, ')'].	^ l capitalized, sh! !!ServiceAction methodsFor: 'accessing' stamp: 'mu 1/19/2008 19:41'!menuLabelNumbered: i	| l sh str |	l := self text translated.	l size > 50		ifTrue: [l := (l first: 47)						, '...'].	sh := self shortcut.	sh := (sh isNil					or: [sh isEmpty])				ifTrue: ['']				ifFalse: [' (' , sh , ')'].	str := i isZero ifTrue: [''] ifFalse: [i asString, '. '].	^ str, l capitalized , sh! !!ServiceCancelled methodsFor: 'as yet unclassified' stamp: 'mu 1/19/2008 19:44'!messageText	^ 'Service has been cancelled' translated! !"Postscript:"ServiceRegistry rebuild.!