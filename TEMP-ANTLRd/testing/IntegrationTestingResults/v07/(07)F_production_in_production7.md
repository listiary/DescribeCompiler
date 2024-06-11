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
│   │   │   └── T(DATA|'macronutrients <ryQ27h6e')
│   │   └── text_chunk
│   │       └── T(RIGHT_ARROW|'> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>\r\n\r\n\t')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'water <hAdLCBLZ')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'salt <GotVxcPm')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   └── expression
│   │   │       ├── item
│   │   │       │   ├── text_chunk
│   │   │       │   │   └── T(DATA|'fiber <CHcd0L0E')
│   │   │       │   └── text_chunk
│   │   │       │       └── T(RIGHT_ARROW|'> ')
│   │   │       ├── producer
│   │   │       │   ├── T(HYPHEN|'-')
│   │   │       │   └── T(RIGHT_ARROW|'>\r\n\r\n        ')
│   │   │       ├── item_or_expression_list
│   │   │       │   ├── item_or_expression_part
│   │   │       │   │   ├── item
│   │   │       │   │   │   ├── text_chunk
│   │   │       │   │   │   │   └── T(DATA|'what <jiSw0LNV')
│   │   │       │   │   │   └── text_chunk
│   │   │       │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │       │   │   └── T(SEPARATOR|',\r\n        ')
│   │   │       │   └── item
│   │   │       │       ├── text_chunk
│   │   │       │       │   └── T(DATA|'not <TpR3PZdW')
│   │   │       │       └── text_chunk
│   │   │       │           └── T(RIGHT_ARROW|'>')
│   │   │       └── T(TERMINATOR|';\r\n\t\r\n\t')
│   │   └── expression
│   │       ├── item
│   │       │   ├── text_chunk
│   │       │   │   └── T(DATA|'science <qlMb3HAO')
│   │       │   └── text_chunk
│   │       │       └── T(RIGHT_ARROW|'> ')
│   │       ├── producer
│   │       │   ├── T(HYPHEN|'-')
│   │       │   └── T(RIGHT_ARROW|'>\r\n\t\t\t\r\n\t\t')
│   │       ├── item_or_expression_list
│   │       │   ├── item_or_expression_part
│   │       │   │   ├── item
│   │       │   │   │   ├── text_chunk
│   │       │   │   │   │   └── T(DATA|'informathics <jn0zFcnW')
│   │       │   │   │   └── text_chunk
│   │       │   │   │       └── T(RIGHT_ARROW|'>')
│   │       │   │   └── T(SEPARATOR|',\r\n\t\t')
│   │       │   ├── item_or_expression_part
│   │       │   │   ├── item
│   │       │   │   │   ├── text_chunk
│   │       │   │   │   │   └── T(DATA|'medicine <JZmdtZj5')
│   │       │   │   │   └── text_chunk
│   │       │   │   │       └── T(RIGHT_ARROW|'>')
│   │       │   │   └── T(SEPARATOR|',\r\n\t\t\r\n\t\t')
│   │       │   └── expression
│   │       │       ├── item
│   │       │       │   ├── text_chunk
│   │       │       │   │   └── T(DATA|'math <bYBIKVXn')
│   │       │       │   └── text_chunk
│   │       │       │       └── T(RIGHT_ARROW|'> ')
│   │       │       ├── producer
│   │       │       │   ├── T(HYPHEN|'-')
│   │       │       │   └── T(RIGHT_ARROW|'>\r\n\t\t\t')
│   │       │       ├── item_or_expression_list
│   │       │       │   ├── item_or_expression_part
│   │       │       │   │   ├── item
│   │       │       │   │   │   ├── text_chunk
│   │       │       │   │   │   │   └── T(DATA|'algebra <nFxP8YKb')
│   │       │       │   │   │   └── text_chunk
│   │       │       │   │   │       └── T(RIGHT_ARROW|'>')
│   │       │       │   │   └── T(SEPARATOR|',\r\n\t\t\t')
│   │       │       │   └── item
│   │       │       │       ├── text_chunk
│   │       │       │       │   └── T(DATA|'geometry <hDNMVYP0')
│   │       │       │       └── text_chunk
│   │       │       │           └── T(RIGHT_ARROW|'>')
│   │       │       └── T(TERMINATOR|';')
│   │       └── T(TERMINATOR|';')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')