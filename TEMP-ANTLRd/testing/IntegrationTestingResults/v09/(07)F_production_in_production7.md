========================================
Source Code (between the arrows)
========================================

🡆macronutrients <ryQ27h6e> ->

	water <hAdLCBLZ>,
    salt <GotVxcPm>,
    fiber <CHcd0L0E> ->

        what <jiSw0LNV>,
        not <TpR3PZdW>;
	
	science <qlMb3HAO> ->
			
		informathics <jn0zFcnW>,
		medicine <JZmdtZj5>,
		
		math <bYBIKVXn> ->
			algebra <nFxP8YKb>,
			geometry <hDNMVYP0>;;;🡄

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
│   │       ├── T(DATA|'ryQ27h6e')
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
│   │   │   │       ├── T(DATA|'hAdLCBLZ')
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'salt ')
│   │   │   │   └── tag
│   │   │   │       ├── T(LEFT_ARROW|'<')
│   │   │   │       ├── T(DATA|'GotVxcPm')
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   └── expression
│   │   │       ├── item
│   │   │       │   ├── text_chunk
│   │   │       │   │   └── T(DATA|'fiber ')
│   │   │       │   └── tag
│   │   │       │       ├── T(LEFT_ARROW|'<')
│   │   │       │       ├── T(DATA|'CHcd0L0E')
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
│   │   │       │   │   │       ├── T(DATA|'jiSw0LNV')
│   │   │       │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │       │   │   └── T(SEPARATOR|',\r\n        ')
│   │   │       │   └── item
│   │   │       │       ├── text_chunk
│   │   │       │       │   └── T(DATA|'not ')
│   │   │       │       └── tag
│   │   │       │           ├── T(LEFT_ARROW|'<')
│   │   │       │           ├── T(DATA|'TpR3PZdW')
│   │   │       │           └── T(RIGHT_ARROW|'>')
│   │   │       └── T(TERMINATOR|';\r\n\t\r\n\t')
│   │   └── expression
│   │       ├── item
│   │       │   ├── text_chunk
│   │       │   │   └── T(DATA|'science ')
│   │       │   └── tag
│   │       │       ├── T(LEFT_ARROW|'<')
│   │       │       ├── T(DATA|'qlMb3HAO')
│   │       │       └── T(RIGHT_ARROW|'> ')
│   │       ├── producer
│   │       │   ├── T(HYPHEN|'-')
│   │       │   └── T(RIGHT_ARROW|'>\r\n\t\t\t\r\n\t\t')
│   │       ├── item_or_expression_list
│   │       │   ├── item_or_expression_part
│   │       │   │   ├── item
│   │       │   │   │   ├── text_chunk
│   │       │   │   │   │   └── T(DATA|'informathics ')
│   │       │   │   │   └── tag
│   │       │   │   │       ├── T(LEFT_ARROW|'<')
│   │       │   │   │       ├── T(DATA|'jn0zFcnW')
│   │       │   │   │       └── T(RIGHT_ARROW|'>')
│   │       │   │   └── T(SEPARATOR|',\r\n\t\t')
│   │       │   ├── item_or_expression_part
│   │       │   │   ├── item
│   │       │   │   │   ├── text_chunk
│   │       │   │   │   │   └── T(DATA|'medicine ')
│   │       │   │   │   └── tag
│   │       │   │   │       ├── T(LEFT_ARROW|'<')
│   │       │   │   │       ├── T(DATA|'JZmdtZj5')
│   │       │   │   │       └── T(RIGHT_ARROW|'>')
│   │       │   │   └── T(SEPARATOR|',\r\n\t\t\r\n\t\t')
│   │       │   └── expression
│   │       │       ├── item
│   │       │       │   ├── text_chunk
│   │       │       │   │   └── T(DATA|'math ')
│   │       │       │   └── tag
│   │       │       │       ├── T(LEFT_ARROW|'<')
│   │       │       │       ├── T(DATA|'bYBIKVXn')
│   │       │       │       └── T(RIGHT_ARROW|'> ')
│   │       │       ├── producer
│   │       │       │   ├── T(HYPHEN|'-')
│   │       │       │   └── T(RIGHT_ARROW|'>\r\n\t\t\t')
│   │       │       ├── item_or_expression_list
│   │       │       │   ├── item_or_expression_part
│   │       │       │   │   ├── item
│   │       │       │   │   │   ├── text_chunk
│   │       │       │   │   │   │   └── T(DATA|'algebra ')
│   │       │       │   │   │   └── tag
│   │       │       │   │   │       ├── T(LEFT_ARROW|'<')
│   │       │       │   │   │       ├── T(DATA|'nFxP8YKb')
│   │       │       │   │   │       └── T(RIGHT_ARROW|'>')
│   │       │       │   │   └── T(SEPARATOR|',\r\n\t\t\t')
│   │       │       │   └── item
│   │       │       │       ├── text_chunk
│   │       │       │       │   └── T(DATA|'geometry ')
│   │       │       │       └── tag
│   │       │       │           ├── T(LEFT_ARROW|'<')
│   │       │       │           ├── T(DATA|'hDNMVYP0')
│   │       │       │           └── T(RIGHT_ARROW|'>')
│   │       │       └── T(TERMINATOR|';')
│   │       └── T(TERMINATOR|';')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')