========================================
Source Code (between the arrows)
========================================

🡆fabric     s 	<TSbLGnNG> ->

	wool   fabrics	 <QWVZ3pp9> ,
	cotton\, fabrics textiles   <75NTfebY>,
    silk\-\>fabrics <Sqs0lm7S>,
    syntic 		fabrics <GcZEI9gy>;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'fabric     s \t')
│   │   └── tag
│   │       ├── T(LEFT_ARROW|'<')
│   │       ├── T(DATA|'TSbLGnNG')
│   │       └── T(RIGHT_ARROW|'> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>\n\n\t')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'wool   fabrics\t ')
│   │   │   │   └── tag
│   │   │   │       ├── T(LEFT_ARROW|'<')
│   │   │   │       ├── T(DATA|'QWVZ3pp9')
│   │   │   │       └── T(RIGHT_ARROW|'> ')
│   │   │   └── T(SEPARATOR|',\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_SEPARATOR|'\,')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|' fabrics textiles   ')
│   │   │   │   └── tag
│   │   │   │       ├── T(LEFT_ARROW|'<')
│   │   │   │       ├── T(DATA|'75NTfebY')
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'silk')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_HYPHEN|'\-')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_RIGHT_ARROW|'\>')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'fabrics ')
│   │   │   │   └── tag
│   │   │   │       ├── T(LEFT_ARROW|'<')
│   │   │   │       ├── T(DATA|'Sqs0lm7S')
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'syntic \t\tfabrics ')
│   │       └── tag
│   │           ├── T(LEFT_ARROW|'<')
│   │           ├── T(DATA|'GcZEI9gy')
│   │           └── T(RIGHT_ARROW|'>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')