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
│   │   │   └── T(DATA|'fabric     s \t<TSbLGnNG')
│   │   └── text_chunk
│   │       └── T(RIGHT_ARROW|'> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>\n\n\t')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'wool   fabrics\t <QWVZ3pp9')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(RIGHT_ARROW|'> ')
│   │   │   └── T(SEPARATOR|',\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_SEPARATOR|'\,')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|' fabrics textiles   <75NTfebY')
│   │   │   │   └── text_chunk
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
│   │   │   │   │   └── T(DATA|'fabrics <Sqs0lm7S')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'syntic \t\tfabrics <GcZEI9gy')
│   │       └── text_chunk
│   │           └── T(RIGHT_ARROW|'>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')