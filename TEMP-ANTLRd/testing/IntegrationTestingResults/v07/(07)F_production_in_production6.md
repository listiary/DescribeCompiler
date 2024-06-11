========================================
Source Code (between the arrows)
========================================

🡆macronutrients <VNvl4KbI> ->

    fiber <BNdiPBY8> ->

        what <47GG8irk>,
        not <vRje122z>;
	
	science <4Zohe6QE> ->
		
		math <u87kglXS> ->
			algebra <VB7KNYBw>,
			geometry <gKznl6RJ>;
			
		informathics <Uon0W1e7>,
		medicine <rBW9kGDK>;
    
    water <3QJz4slg>,
    salt <X2BTGncx>;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'macronutrients <VNvl4KbI')
│   │   └── text_chunk
│   │       └── T(RIGHT_ARROW|'> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>\r\n\r\n    ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   └── expression
│   │   │       ├── item
│   │   │       │   ├── text_chunk
│   │   │       │   │   └── T(DATA|'fiber <BNdiPBY8')
│   │   │       │   └── text_chunk
│   │   │       │       └── T(RIGHT_ARROW|'> ')
│   │   │       ├── producer
│   │   │       │   ├── T(HYPHEN|'-')
│   │   │       │   └── T(RIGHT_ARROW|'>\r\n\r\n        ')
│   │   │       ├── item_or_expression_list
│   │   │       │   ├── item_or_expression_part
│   │   │       │   │   ├── item
│   │   │       │   │   │   ├── text_chunk
│   │   │       │   │   │   │   └── T(DATA|'what <47GG8irk')
│   │   │       │   │   │   └── text_chunk
│   │   │       │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │       │   │   └── T(SEPARATOR|',\r\n        ')
│   │   │       │   └── item
│   │   │       │       ├── text_chunk
│   │   │       │       │   └── T(DATA|'not <vRje122z')
│   │   │       │       └── text_chunk
│   │   │       │           └── T(RIGHT_ARROW|'>')
│   │   │       └── T(TERMINATOR|';\r\n\t\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   └── expression
│   │   │       ├── item
│   │   │       │   ├── text_chunk
│   │   │       │   │   └── T(DATA|'science <4Zohe6QE')
│   │   │       │   └── text_chunk
│   │   │       │       └── T(RIGHT_ARROW|'> ')
│   │   │       ├── producer
│   │   │       │   ├── T(HYPHEN|'-')
│   │   │       │   └── T(RIGHT_ARROW|'>\r\n\t\t\r\n\t\t')
│   │   │       ├── item_or_expression_list
│   │   │       │   ├── item_or_expression_part
│   │   │       │   │   └── expression
│   │   │       │   │       ├── item
│   │   │       │   │       │   ├── text_chunk
│   │   │       │   │       │   │   └── T(DATA|'math <u87kglXS')
│   │   │       │   │       │   └── text_chunk
│   │   │       │   │       │       └── T(RIGHT_ARROW|'> ')
│   │   │       │   │       ├── producer
│   │   │       │   │       │   ├── T(HYPHEN|'-')
│   │   │       │   │       │   └── T(RIGHT_ARROW|'>\r\n\t\t\t')
│   │   │       │   │       ├── item_or_expression_list
│   │   │       │   │       │   ├── item_or_expression_part
│   │   │       │   │       │   │   ├── item
│   │   │       │   │       │   │   │   ├── text_chunk
│   │   │       │   │       │   │   │   │   └── T(DATA|'algebra <VB7KNYBw')
│   │   │       │   │       │   │   │   └── text_chunk
│   │   │       │   │       │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │       │   │       │   │   └── T(SEPARATOR|',\r\n\t\t\t')
│   │   │       │   │       │   └── item
│   │   │       │   │       │       ├── text_chunk
│   │   │       │   │       │       │   └── T(DATA|'geometry <gKznl6RJ')
│   │   │       │   │       │       └── text_chunk
│   │   │       │   │       │           └── T(RIGHT_ARROW|'>')
│   │   │       │   │       └── T(TERMINATOR|';\r\n\t\t\t\r\n\t\t')
│   │   │       │   ├── item_or_expression_part
│   │   │       │   │   ├── item
│   │   │       │   │   │   ├── text_chunk
│   │   │       │   │   │   │   └── T(DATA|'informathics <Uon0W1e7')
│   │   │       │   │   │   └── text_chunk
│   │   │       │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │       │   │   └── T(SEPARATOR|',\r\n\t\t')
│   │   │       │   └── item
│   │   │       │       ├── text_chunk
│   │   │       │       │   └── T(DATA|'medicine <rBW9kGDK')
│   │   │       │       └── text_chunk
│   │   │       │           └── T(RIGHT_ARROW|'>')
│   │   │       └── T(TERMINATOR|';\r\n    \r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'water <3QJz4slg')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'salt <X2BTGncx')
│   │       └── text_chunk
│   │           └── T(RIGHT_ARROW|'>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')