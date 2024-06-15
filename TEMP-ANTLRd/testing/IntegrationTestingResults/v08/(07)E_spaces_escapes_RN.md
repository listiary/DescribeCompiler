========================================
Source Code (between the arrows)
========================================

🡆fabric     s    <sJZOzSdo>	->

	wool   fabrics	<UlJXGWLS> ,
	cotton\, fabrics textiles  \<<d4jKusMe>,
    silk\->fabrics <Bgx8/M6B1>,
    syntic 		fabrics <7vb\\W9VSB>;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'fabric     s    ')
│   │   └── tag
│   │       ├── T(LEFT_ARROW|'<')
│   │       ├── T(DATA|'sJZOzSdo')
│   │       └── T(RIGHT_ARROW|'>\t')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>\r\n\r\n\t')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'wool   fabrics\t')
│   │   │   │   └── tag
│   │   │   │       ├── T(LEFT_ARROW|'<')
│   │   │   │       ├── T(DATA|'UlJXGWLS')
│   │   │   │       └── T(RIGHT_ARROW|'> ')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_SEPARATOR|'\,')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|' fabrics textiles  ')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_LEFT_ARROW|'\<')
│   │   │   │   └── tag
│   │   │   │       ├── T(LEFT_ARROW|'<')
│   │   │   │       ├── T(DATA|'d4jKusMe')
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'silk')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_HYPHEN|'\-')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(RIGHT_ARROW|'>')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'fabrics ')
│   │   │   │   └── tag
│   │   │   │       ├── T(LEFT_ARROW|'<')
│   │   │   │       ├── T(DATA|'Bgx8')
│   │   │   │       ├── T(FORWARD_SLASH|'/')
│   │   │   │       ├── T(DATA|'M6B1')
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'syntic \t\tfabrics ')
│   │       └── tag
│   │           ├── T(LEFT_ARROW|'<')
│   │           ├── T(DATA|'7vb')
│   │           ├── T(ESCAPE_ESCAPE|'\\')
│   │           ├── T(DATA|'W9VSB')
│   │           └── T(RIGHT_ARROW|'>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')