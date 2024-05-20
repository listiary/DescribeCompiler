========================================
Source Code (between the arrows)
========================================

🡆fabric     s 	->

	wool   fabrics	,
	cotton\, fabrics textiles  ,
    silk\->fabrics,
    syntic 		fabrics;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   └── text_chunk
│   │       └── T(DATA|'fabric     s \t')
│   ├── item_or_expression_list
│   │   ├── item
│   │   │   └── text_chunk
│   │   │       └── T(DATA|'

\twool   fabrics\t')
│   │   ├── T(SEPARATOR|',')
│   │   └── item_or_expression_list
│   │       ├── item
│   │       │   ├── text_chunk
│   │       │   │   └── T(DATA|'
\tcotton')
│   │       │   ├── text_chunk
│   │       │   │   └── T(ESCAPE_SEPARATOR|'\,')
│   │       │   └── text_chunk
│   │       │       └── T(DATA|' fabrics textiles  ')
│   │       ├── T(SEPARATOR|',')
│   │       └── item_or_expression_list
│   │           ├── item
│   │           │   ├── text_chunk
│   │           │   │   └── T(DATA|'
    silk')
│   │           │   ├── text_chunk
│   │           │   │   └── T(ESCAPE_HYPHEN|'\-')
│   │           │   ├── text_chunk
│   │           │   │   └── T(RIGHT_ARROW|'>')
│   │           │   └── text_chunk
│   │           │       └── T(DATA|'fabrics')
│   │           ├── T(SEPARATOR|',')
│   │           └── item_or_expression
│   │               └── item
│   │                   └── text_chunk
│   │                       └── T(DATA|'
    syntic \t\tfabrics')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')