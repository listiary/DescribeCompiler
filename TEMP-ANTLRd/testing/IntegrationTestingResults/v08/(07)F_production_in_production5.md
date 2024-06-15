========================================
Source Code (between the arrows)
========================================

🡆macronutrients <SxOf3elF> ->

	water <8S3IwDlG>,
    salt <RV4OUQoy>,
    fiber <G3tWgyDr> ->

        what <AwPl7oBK>,
        not <OcIUTGif>;
	
	science <k543P1uB> ->
		
		math <IZZ9vPiK>,
		informathics <OMH9y9Jn>,
		medicine <UuA1ITf9>;;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'macronutrients ')
│   │   └── tag
│   │       ├── T(LEFT_ARROW|'<')
│   │       ├── T(DATA|'SxOf3elF')
│   │       └── T(RIGHT_ARROW|'> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>\r\n\r\n\t')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'water ')
│   │   │   │   └── tag
│   │   │   │       ├── T(LEFT_ARROW|'<')
│   │   │   │       ├── T(DATA|'8S3IwDlG')
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'salt ')
│   │   │   │   └── tag
│   │   │   │       ├── T(LEFT_ARROW|'<')
│   │   │   │       ├── T(DATA|'RV4OUQoy')
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   └── expression
│   │   │       ├── item
│   │   │       │   ├── text_chunk
│   │   │       │   │   └── T(DATA|'fiber ')
│   │   │       │   └── tag
│   │   │       │       ├── T(LEFT_ARROW|'<')
│   │   │       │       ├── T(DATA|'G3tWgyDr')
│   │   │       │       └── T(RIGHT_ARROW|'> ')
│   │   │       ├── producer
│   │   │       │   ├── T(HYPHEN|'-')
│   │   │       │   └── T(RIGHT_ARROW|'>\r\n\r\n        ')
│   │   │       ├── item_or_expression_list
│   │   │       │   ├── item_or_expression_part
│   │   │       │   │   ├── item
│   │   │       │   │   │   ├── text_chunk
│   │   │       │   │   │   │   └── T(DATA|'what ')
│   │   │       │   │   │   └── tag
│   │   │       │   │   │       ├── T(LEFT_ARROW|'<')
│   │   │       │   │   │       ├── T(DATA|'AwPl7oBK')
│   │   │       │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │       │   │   └── T(SEPARATOR|',\r\n        ')
│   │   │       │   └── item
│   │   │       │       ├── text_chunk
│   │   │       │       │   └── T(DATA|'not ')
│   │   │       │       └── tag
│   │   │       │           ├── T(LEFT_ARROW|'<')
│   │   │       │           ├── T(DATA|'OcIUTGif')
│   │   │       │           └── T(RIGHT_ARROW|'>')
│   │   │       └── T(TERMINATOR|';\r\n\t\r\n\t')
│   │   └── expression
│   │       ├── item
│   │       │   ├── text_chunk
│   │       │   │   └── T(DATA|'science ')
│   │       │   └── tag
│   │       │       ├── T(LEFT_ARROW|'<')
│   │       │       ├── T(DATA|'k543P1uB')
│   │       │       └── T(RIGHT_ARROW|'> ')
│   │       ├── producer
│   │       │   ├── T(HYPHEN|'-')
│   │       │   └── T(RIGHT_ARROW|'>\r\n\t\t\r\n\t\t')
│   │       ├── item_or_expression_list
│   │       │   ├── item_or_expression_part
│   │       │   │   ├── item
│   │       │   │   │   ├── text_chunk
│   │       │   │   │   │   └── T(DATA|'math ')
│   │       │   │   │   └── tag
│   │       │   │   │       ├── T(LEFT_ARROW|'<')
│   │       │   │   │       ├── T(DATA|'IZZ9vPiK')
│   │       │   │   │       └── T(RIGHT_ARROW|'>')
│   │       │   │   └── T(SEPARATOR|',\r\n\t\t')
│   │       │   ├── item_or_expression_part
│   │       │   │   ├── item
│   │       │   │   │   ├── text_chunk
│   │       │   │   │   │   └── T(DATA|'informathics ')
│   │       │   │   │   └── tag
│   │       │   │   │       ├── T(LEFT_ARROW|'<')
│   │       │   │   │       ├── T(DATA|'OMH9y9Jn')
│   │       │   │   │       └── T(RIGHT_ARROW|'>')
│   │       │   │   └── T(SEPARATOR|',\r\n\t\t')
│   │       │   └── item
│   │       │       ├── text_chunk
│   │       │       │   └── T(DATA|'medicine ')
│   │       │       └── tag
│   │       │           ├── T(LEFT_ARROW|'<')
│   │       │           ├── T(DATA|'UuA1ITf9')
│   │       │           └── T(RIGHT_ARROW|'>')
│   │       └── T(TERMINATOR|';')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')