========================================
Source Code (between the arrows)
========================================

🡆fabric     s 	[https://www.notube.com/watch?v=hTui12lKus]     <TSbLGnNG> ->

	wool   fabrics	 <QWVZ3pp9> [https://www.notube.com/watch?v=hTui12lKus],
	cotton\[ fabrics textiles [https://www.notube.com/watch?v=hTui12lKus]   <75NTfebY>,
    silk\[\[\[\]fabrics <Sqs0lm7S>[https://www.notube.com/watch?v=hTui12lKus],
    syntic 		fabrics <GcZEI9gy>;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'fabric     s \t')
│   │   ├── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]     ')
│   │   └── tag
│   │       ├── T(LEFT_ARROW|'<')
│   │       ├── T(DATA|'TSbLGnNG')
│   │       └── T(RIGHT_ARROW|'> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>\r\n\r\n\t')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'wool   fabrics\t ')
│   │   │   │   ├── tag
│   │   │   │   │   ├── T(LEFT_ARROW|'<')
│   │   │   │   │   ├── T(DATA|'QWVZ3pp9')
│   │   │   │   │   └── T(RIGHT_ARROW|'> ')
│   │   │   │   └── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_LEFT_SQUARE|'\[')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|' fabrics textiles ')
│   │   │   │   ├── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]   ')
│   │   │   │   └── tag
│   │   │   │       ├── T(LEFT_ARROW|'<')
│   │   │   │       ├── T(DATA|'75NTfebY')
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'silk')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_LEFT_SQUARE|'\[')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_LEFT_SQUARE|'\[')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_LEFT_SQUARE|'\[')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_RIGHT_SQUARE|'\]')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'fabrics ')
│   │   │   │   ├── tag
│   │   │   │   │   ├── T(LEFT_ARROW|'<')
│   │   │   │   │   ├── T(DATA|'Sqs0lm7S')
│   │   │   │   │   └── T(RIGHT_ARROW|'>')
│   │   │   │   └── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'syntic \t\tfabrics ')
│   │       └── tag
│   │           ├── T(LEFT_ARROW|'<')
│   │           ├── T(DATA|'GcZEI9gy')
│   │           └── T(RIGHT_ARROW|'>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')