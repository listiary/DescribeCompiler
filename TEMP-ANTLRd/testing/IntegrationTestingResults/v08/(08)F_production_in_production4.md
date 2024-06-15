========================================
Source Code (between the arrows)
========================================

🡆macronutrients <xkQxOfc9> ->

    fiber <CbALGP8d> ->

        what <7KNUmetK>,
        not [http://testlink.com/] <6qFQ0HxK>;
	
	science <o8lvOnlB> ->
		
		math <SbQjE2YS>,
		informathics <CVOSiiAS>,
		medicine [http://testlink.com/] <1G0hZLJ4>;
    
    water <ozhHnNOU>,
    salt <jMBLOKGE>;🡄

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
│   │       ├── T(DATA|'xkQxOfc9')
│   │       └── T(RIGHT_ARROW|'> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>\r\n\r\n    ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   └── expression
│   │   │       ├── item
│   │   │       │   ├── text_chunk
│   │   │       │   │   └── T(DATA|'fiber ')
│   │   │       │   └── tag
│   │   │       │       ├── T(LEFT_ARROW|'<')
│   │   │       │       ├── T(DATA|'CbALGP8d')
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
│   │   │       │   │   │       ├── T(DATA|'7KNUmetK')
│   │   │       │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │       │   │   └── T(SEPARATOR|',\r\n        ')
│   │   │       │   └── item
│   │   │       │       ├── text_chunk
│   │   │       │       │   └── T(DATA|'not ')
│   │   │       │       ├── T(LINK|'[http://testlink.com/] ')
│   │   │       │       └── tag
│   │   │       │           ├── T(LEFT_ARROW|'<')
│   │   │       │           ├── T(DATA|'6qFQ0HxK')
│   │   │       │           └── T(RIGHT_ARROW|'>')
│   │   │       └── T(TERMINATOR|';\r\n\t\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   └── expression
│   │   │       ├── item
│   │   │       │   ├── text_chunk
│   │   │       │   │   └── T(DATA|'science ')
│   │   │       │   └── tag
│   │   │       │       ├── T(LEFT_ARROW|'<')
│   │   │       │       ├── T(DATA|'o8lvOnlB')
│   │   │       │       └── T(RIGHT_ARROW|'> ')
│   │   │       ├── producer
│   │   │       │   ├── T(HYPHEN|'-')
│   │   │       │   └── T(RIGHT_ARROW|'>\r\n\t\t\r\n\t\t')
│   │   │       ├── item_or_expression_list
│   │   │       │   ├── item_or_expression_part
│   │   │       │   │   ├── item
│   │   │       │   │   │   ├── text_chunk
│   │   │       │   │   │   │   └── T(DATA|'math ')
│   │   │       │   │   │   └── tag
│   │   │       │   │   │       ├── T(LEFT_ARROW|'<')
│   │   │       │   │   │       ├── T(DATA|'SbQjE2YS')
│   │   │       │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │       │   │   └── T(SEPARATOR|',\r\n\t\t')
│   │   │       │   ├── item_or_expression_part
│   │   │       │   │   ├── item
│   │   │       │   │   │   ├── text_chunk
│   │   │       │   │   │   │   └── T(DATA|'informathics ')
│   │   │       │   │   │   └── tag
│   │   │       │   │   │       ├── T(LEFT_ARROW|'<')
│   │   │       │   │   │       ├── T(DATA|'CVOSiiAS')
│   │   │       │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │       │   │   └── T(SEPARATOR|',\r\n\t\t')
│   │   │       │   └── item
│   │   │       │       ├── text_chunk
│   │   │       │       │   └── T(DATA|'medicine ')
│   │   │       │       ├── T(LINK|'[http://testlink.com/] ')
│   │   │       │       └── tag
│   │   │       │           ├── T(LEFT_ARROW|'<')
│   │   │       │           ├── T(DATA|'1G0hZLJ4')
│   │   │       │           └── T(RIGHT_ARROW|'>')
│   │   │       └── T(TERMINATOR|';\r\n    \r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'water ')
│   │   │   │   └── tag
│   │   │   │       ├── T(LEFT_ARROW|'<')
│   │   │   │       ├── T(DATA|'ozhHnNOU')
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'salt ')
│   │       └── tag
│   │           ├── T(LEFT_ARROW|'<')
│   │           ├── T(DATA|'jMBLOKGE')
│   │           └── T(RIGHT_ARROW|'>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')